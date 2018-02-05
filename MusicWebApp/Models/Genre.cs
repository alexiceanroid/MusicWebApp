using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string ImageLocation { get; set; }

        public List<Track> Tracks { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
