using System.Collections.Generic;

namespace Pixabay.Model
{
    public class Gallery
    {
        public int total { get; set; }
        public int totalHits { get; set; }
        public List<Hits> hits { get; set; }
    }
}