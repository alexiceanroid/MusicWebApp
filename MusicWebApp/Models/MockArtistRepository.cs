using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class MockArtistRepository : IArtistRepository
    {
        public IEnumerable<Artist> Artists => new List<Artist>
        {
            new Artist {ArtistId = 1, Name = "Asheni"},
            new Artist {ArtistId = 2, Name = "Aerosmith"},
            new Artist {ArtistId = 3, Name = "Paul van Dyk"}
        };
    }
}
