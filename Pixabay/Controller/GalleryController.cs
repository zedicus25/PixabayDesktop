using System;
using System.Net;
using System.Text.Json;
using Pixabay.Model;

namespace Pixabay.Controller
{
    public class GalleryController
    {
        public Gallery Gallery { get; private set; }
        private WebClient _client;
        private string _address;

        public GalleryController()
        {
            _client = new WebClient();
            _address = @"https://pixabay.com/api/?key=28501111-b5439624e74b8a51021b4ec3e&pretty=true";
            Gallery = GetJson(_client.DownloadString(_address));
        }

        private Gallery GetJson(string reply)
        {
            if (reply.Equals(String.Empty))
                throw new ArgumentException("Reply cannot be empty");
            return JsonSerializer.Deserialize<Gallery>(reply);
        }
    }
}