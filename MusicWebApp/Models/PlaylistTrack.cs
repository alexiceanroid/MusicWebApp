using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class PlaylistTrack
    {
        public int Id { get; set; }
        public Playlist Playlist { get; set; }
        public Track Track { get; set; }
    }
}
