using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public List<Track> Tracks { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
