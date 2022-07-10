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
        public event Action<string> SendMsg;
        public Gallery Gallery { get; private set; }

        public Task DownloadTask { get; private set; }

        private WebClient _client;
        private string _address;
        public string AddressForDownload { get; private set; }
        public int CurrentPage { get; private set; }
        private int _maxPage;
        private int _minPage;
        private string _previousSearch;

        public GalleryController()
        {
            // _addressForDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\PreviewImages";
            //if(CheckFolder("PreviewImages") == false)
            // Directory.CreateDirectory(_addressForDownload);

            AddressForDownload = @"F:\PreviewImages";
            _client = new WebClient();
            _address = @"https://pixabay.com/api/?key=28501111-b5439624e74b8a51021b4ec3e&pretty=true";
            Gallery = GetJson(_client.DownloadString(_address));
            CurrentPage = _minPage = 1; 
            _previousSearch = string.Empty;
            StartDownloadFiles();
        }

        public void StartDownloadFiles()
        {
            DownloadTask = new Task(DownloadPreviewFiles);
            DownloadTask.Start();
            DownloadTask.Wait();
            _maxPage = Gallery.totalHits / Gallery.hits.Count;
        }

        private void DownloadPreviewFiles()
        {
            if (Gallery == null)
                throw new NullReferenceException("Gallery was null");
            string name = String.Empty;
            foreach (var item in Gallery.hits)
            {
                name = item.previewURL.Substring(item.previewURL.LastIndexOf('/')+1);
                string path = Path.Combine(AddressForDownload, name);
                _client.DownloadFile(new Uri(item.previewURL), path);
            }
        }

        private Gallery GetJson(string reply)
        {
            if (reply.Equals(String.Empty))
                throw new ArgumentException("Reply cannot be empty");
            return JsonSerializer.Deserialize<Gallery>(reply);
        }

        public void GoToPage(int page)
        {
            if (page < _minPage || page > _maxPage)
            {
                SendMsg?.Invoke("Page exceeds the maximum or minimum");
                return;
            }

            if (_address.Contains("&page="))
            {
                _address = _address.Replace($"&page={(page > CurrentPage ? CurrentPage-1:CurrentPage)}", $"&page={page}");
            }
            else if (!_address.Contains("&page="))
            {
                _address += $"&page={page}";
            }

            CurrentPage = page;
            ClearGallery();
            Gallery = GetJson(_client.DownloadString(_address));
            StartDownloadFiles();
        }

        public void Search(string search)
        {
            if (_address.Contains("&q="))
            {
                _address = _address.Replace($"&q={_previousSearch}", $"&q={search}");
            }
            else if (!_address.Contains("&q="))
            {
                _address += $"&q={search}";
            }

            _previousSearch = search;
            ClearGallery();
            Gallery = GetJson(_client.DownloadString(_address));
            StartDownloadFiles();
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
            foreach (var item in Directory.GetFiles(AddressForDownload))
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