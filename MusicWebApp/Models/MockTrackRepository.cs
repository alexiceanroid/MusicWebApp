using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class MockTrackRepository : ITrackRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();
        private readonly IArtistRepository _artistRepository = new MockArtistRepository();

        public IEnumerable<Track> Tracks => new List<Track>
        {
            new Track {TrackId = 1, Name = "Crazy", ArtistId = 2, Size = 4650}, // rock
            new Track{TrackId = 2, Name = "I don't wanna miss a thing", ArtistId = 2, Size = 7800}, // rock
            new Track{TrackId = 3, Name = "Sweet suffering", ArtistId = 1, Size = 12400}, // chillout
            new Track{TrackId = 4, Name = "The other side", ArtistId = 3, Size = 11500}, // trance
            new Track{TrackId = 5, Name = "Crush", ArtistId = 3, Size = 9800} // trance
        };
        public IEnumerable<Track> FavouriteTracks { get; }
        public Track GetTrackById(int trackId)
        {
            throw new NotImplementedException();
        }
    }
}
