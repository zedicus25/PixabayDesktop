using Pixabay.Model;
using System;
using System.Collections.Generic;
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
        public string FilePath { get; set; }

        public Hits Hit { get; private set; }

        private WebClient _client;

        public HitsController(Hits hits)
        {
            Hit = hits;
            _addressForDownload = @"F:\PreviewImages\WebImages";
            FileName = hits.webformatURL.Substring(hits.webformatURL.LastIndexOf('/') + 1);
            FileName.Replace('/', '_');
            FilePath = Path.Combine(_addressForDownload, FileName);
            _client = new WebClient();
            _client.DownloadFile(Hit.webformatURL, FilePath);
        }

        public void ClearDirectory()
        {
            File.Delete(FilePath);
        }
    }
}
