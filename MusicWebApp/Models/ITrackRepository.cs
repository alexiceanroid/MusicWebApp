using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public interface ITrackRepository
    {
        IEnumerable<Track> Tracks { get; }
        IEnumerable<Track> FavouriteTracks { get; }

        Track GetTrackById(int trackId);
    }
}
