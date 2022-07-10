using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Pixabay.Model;

namespace Pixabay.Controller
{
    public class GalleryController
    {
        public Gallery Gallery { get; private set; }

        public Task DownloadTask { get; private set; }

        private WebClient _client;
        private string _address;
        private string _addressForDownload;

        public GalleryController()
        {
            // _addressForDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\PreviewImages";
            //if(CheckFolder("PreviewImages") == false)
            // Directory.CreateDirectory(_addressForDownload);

            _addressForDownload = @"F:\PreviewImages";
            _client = new WebClient();
            _address = @"https://pixabay.com/api/?key=28501111-b5439624e74b8a51021b4ec3e&pretty=true";
            Gallery = GetJson(_client.DownloadString(_address));
            StartDownloadFiles();
        }

        public void StartDownloadFiles()
        {
            DownloadTask = new Task(DownloadPreviewFiles);
            DownloadTask.Start();
        }

        private void DownloadPreviewFiles()
        {
            if (Gallery == null)
                throw new NullReferenceException("Gallery was null");
            string name = String.Empty;
            foreach (var item in Gallery.hits)
            {
                name = item.previewURL.Substring(item.previewURL.LastIndexOf('/')+1);
                _client.DownloadFile(item.previewURL, Path.Combine(_addressForDownload,name));
            }
        }

        private Gallery GetJson(string reply)
        {
            if (reply.Equals(String.Empty))
                throw new ArgumentException("Reply cannot be empty");
            return JsonSerializer.Deserialize<Gallery>(reply);
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

        public void ClearGallery()
        {
            foreach (var item in Directory.GetFiles(_addressForDownload))
            {
                File.Delete(item);
            }
        }

        ~GalleryController()
        {
            ClearGallery();
        }
    }
}