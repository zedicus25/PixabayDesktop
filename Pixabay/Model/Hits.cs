namespace Pixabay.Model
{
    public class Hits
    {
        public int id { get; set; }
        public string tags { get; set; }
        
        public string previewURL { get; set; }
        public int previewWidth { get; set; }
        public int previewHeight { get; set; }
        
        public string webFormatURL { get; set; }
        public int webFormatWidth { get; set; }
        public int webFormatHeight { get; set; }
        
        public string largeImageURL { get; set; }
        public int imageWidth { get; set; }
        public int imageHeight { get; set; }

        public int views { get; set; }
        public int downloads { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }

        public string user { get; set; }
    }
}