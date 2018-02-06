using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Album { get; set; }
        public int YearReleased { get; set; }
        public int Length { get; set; }
        public int Bitrate { get; set; }
        public string Lyrics { get; set; }

        public string ItemType { get; set; } // e.g.: AIMP: MPEG Layer 3
        public string TrackSource { get; set; } // e.g.: local, URL...
        public string FolderPath { get; set; }
        public string TrackUrl { get; set; }
        public string ImageLocation { get; set; }
        
        public int Size { get; set; }
        

        public Genre Genre { get; set; }

        //public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public List<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
