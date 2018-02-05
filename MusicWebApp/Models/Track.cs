using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lyrics { get; set; }
        public string ImageLocation { get; set; }
        public int Rating { get; set; }
        public int Size { get; set; }

        public List<Genre> Genres { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
