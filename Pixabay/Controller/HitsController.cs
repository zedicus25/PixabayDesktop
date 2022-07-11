using Pixabay.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pixabay.Controller
{
    internal class HitsController
    {
        private string _addressForDownload;
        public string FileName { get; private set; }
        public string FilePath { get; private set; }
        public string UserImage { get; private set; }

        public Hits Hit { get; private set; }

        private WebClient _client;
        private string _pathForSaving;

        public HitsController(Hits hits)
        {
            _pathForSaving = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Downloads";

            if (CheckFolder("Downloads") == false)
                Directory.CreateDirectory(_pathForSaving);

            Hit = hits;
            _addressForDownload = @"F:\PreviewImages\WebImages";
            FileName = hits.webformatURL.Substring(hits.webformatURL.LastIndexOf('/') + 1);
            FileName.Replace('/', '_');
            FilePath = Path.Combine(_addressForDownload, FileName);
            _client = new WebClient();
            _client.DownloadFile(Hit.webformatURL, FilePath);

            string name = Hit.userImageURL.Substring(Hit.userImageURL.LastIndexOf('/') + 1);
            UserImage = Path.Combine(_addressForDownload, name);
            _client.DownloadFile(Hit.userImageURL, UserImage);

        }

        public void DownloadFile(string res)
        {
            int width = int.Parse(res.Substring(0, res.IndexOf('x')));
            int height = int.Parse(res.Substring(res.IndexOf('x') + 1));

            if (width.Equals(Hit.webformatWidth))
            {
                File.Copy(FilePath, Path.Combine(_pathForSaving, FileName));
                return;
            }
            if (width.Equals(Hit.webformatWidth * 2))
            {
                _client.DownloadFile(Hit.largeImageURL, Path.Combine(_pathForSaving, FileName));
                return;
            }
            _client.DownloadFile(Hit.largeImageURL,
                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), FileName));

            byte[] bytes = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), FileName));
            FileStream fs = new FileStream(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), FileName), FileMode.Open, FileAccess.Read, FileShare.None);
            fs.Read(bytes, 0, bytes.Length);
            Image im = Image.FromStream(fs);
            fs.Close();
            fs.Dispose();

            Bitmap bit = new Bitmap(im, new Size(width, height));
            bit.Save(Path.Combine(_pathForSaving, FileName));
            bit.Dispose();
            im.Dispose();

            File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), FileName));
            GC.Collect(GC.GetGeneration(bytes));
            GC.Collect(GC.GetGeneration(fs));
            GC.Collect(GC.GetGeneration(im));
            GC.Collect(GC.GetGeneration(bit));


        }

        public void ClearDirectory()
        {
            File.Delete(FilePath);
            File.Delete(UserImage);
        }

        private bool CheckFolder(string folder)
        {
            foreach (var item in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)))
            {
                if (item.Equals(folder))
                    return true;
            }
            return false;
        }
    }
}
