using System.Collections.Generic;

namespace MusicWebApp.Models.Interfaces
{
    public interface ITrackRepository
    {
        IEnumerable<Track> Tracks { get; }
        IEnumerable<Track> FavouriteTracks { get; }

        Track GetTrackById(int trackId);
    }
}
