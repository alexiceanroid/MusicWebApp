using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWebApp.Models
{
    public class MockGenreRepository : IGenreRepository
    {
        public IEnumerable<Genre> Genres => new List<Genre>
        {
            new Genre{GenreId = 1, Name="Chillout", ImageLocation="/images/genres/chillout.jpg"},
            new Genre{GenreId = 2, Name = "Rock", ImageLocation="/images/genres/rock.jpg"},
            new Genre{GenreId = 3, Name = "Trance", ImageLocation="/images/genres/trance.jpg"}
        };
    }
}
