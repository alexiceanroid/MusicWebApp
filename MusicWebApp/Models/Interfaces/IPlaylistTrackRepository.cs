using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models.Interfaces
{
    public interface IPlaylistTrackRepository
    {
        IEnumerable<PlaylistTrack> PlaylistTracks { get; }
    }
}
