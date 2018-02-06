using System.Collections.Generic;
using System.Linq;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class MockArtistRepository : IArtistRepository
    {
        public IEnumerable<Artist> Artists
        {
            get
            {
                var artists = new List<Artist>();
                
                //asheni
                var asheni = new Artist {ArtistId = 1, Name = "Asheni"};
                int asheniGenreId = 1;
                var asheniGenre = (new MockGenreRepository()).Genres.FirstOrDefault(g => g.GenreId == asheniGenreId);
                //asheni.GenreId = asheniGenreId;
                asheni.Genre = asheniGenre;
                artists.Add(asheni);

                //aerosmith
                var aerosmith = new Artist { ArtistId = 2, Name = "Aerosmith" };
                int aerosmithGenreId = 2;
                var aerosmithGenre = (new MockGenreRepository()).Genres.FirstOrDefault(g => g.GenreId == aerosmithGenreId);
                //aerosmith.GenreId = aerosmithGenreId;
                aerosmith.Genre = aerosmithGenre;
                artists.Add(aerosmith);

                //paul van dyk
                var pvd = new Artist { ArtistId = 2, Name = "Paul van Dyk" };
                int pvdGenreId = 3;
                var pvdGenre = (new MockGenreRepository()).Genres.FirstOrDefault(g => g.GenreId == pvdGenreId);
                //pvd.GenreId = pvdGenreId;
                pvd.Genre = pvdGenre;
                artists.Add(pvd);

                return artists;
            }
        } 
        
    }
}
