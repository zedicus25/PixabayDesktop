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
        public int MaxPage { get; private set; }
        private int _minPage;
        private string _previousSearch;
        private bool _saveSearch = false;
        private bool _editorsChoice = false;
        private string _order;
        private string _orientation;
        private string _imageType;
        private int _minWidth;
        private int _minHeight;

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
            DownloadTask?.Dispose();
            DownloadTask = new Task(DownloadPreviewFiles);
            DownloadTask.Start();
            DownloadTask.Wait();
            MaxPage = Gallery.totalHits / Gallery.hits.Count;
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
            if (page < _minPage || page > MaxPage)
            {
                SendMsg?.Invoke("Page exceeds the maximum or minimum");
                return;
            }
           

            if (_address.Contains("&page="))
            {
                _address = _address.Replace($"&page={CurrentPage}", $"&page={page}");
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
            search = search.Replace(' ', '+');
            search = search.ToLower();
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
            GoToPage(1);
        }

        public void SetSaveSearch(bool val)
        {
            if (_address.Contains("&safesearch="))
            {
                _address = _address.Replace($"&safesearch={(!val).ToString().ToLower()}", $"&safesearch={val.ToString().ToLower()}");
            }
            else if (!_address.Contains("&safesearch="))
            {
                _address += $"&safesearch={val.ToString().ToLower()}";
            }
            _saveSearch = val;
            ClearGallery();
            Gallery = GetJson(_client.DownloadString(_address));
            StartDownloadFiles();
            GoToPage(1);
        }

        public void SetMinSize(int width, int height)
        {
            if (width < 0)
                width = 0;
            if (height < 0)
                height = 0;
            if (_address.Contains("&min_width="))
            {
                _address = _address.Replace($"&min_width={_minWidth}", $"&min_width={width}");
            }
            else if (!_address.Contains("&min_widthh="))
            {
                _address += $"&min_width={width}";
            }

            if (_address.Contains("&min_height="))
            {
                _address = _address.Replace($"&min_height={_minHeight}", $"&min_height={height}");
            }
            else if (!_address.Contains("&min_height="))
            {
                _address += $"&min_height={height}";
            }
            _minWidth = width;
            _minHeight = height;

            ClearGallery();
            Gallery = GetJson(_client.DownloadString(_address));
            StartDownloadFiles();
            GoToPage(1);

        }



        public void ClearFilters()
        {
            if (_address.Contains("&safesearch="))
            {
                _address.Replace($"&safesearch={_saveSearch}", "");
            }

            if (_address.Contains("&order="))
            {
                _address.Replace($"&order={_order}", "");
            }

            if (_address.Contains("&editors_choice="))
            {
                _address.Replace($"&editors_choicer={_editorsChoice}", "");
            }

            if (_address.Contains("&orientation="))
            {
                _address.Replace($"&orientation={_orientation}", "");
            }

            if (_address.Contains("&image_type="))
            {
                _address.Replace($"&image_type={_imageType}", "");
            }

            if (_address.Contains("&min_width="))
            {
                _address.Replace($"&min_width={_minWidth}", "");
            }

            if (_address.Contains("&min_height="))
            {
                _address.Replace($"&min_height={_minHeight}", "");
            }
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