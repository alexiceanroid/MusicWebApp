using System.Collections.Generic;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class MockGenreRepository : IGenreRepository
    {
        public IEnumerable<Genre> Genres => new List<Genre>
        {
            new Genre{GenreId = 1, Name="Chillout", ImageLocation="/images/genres/chillout_200x220.jpg"},
            new Genre{GenreId = 2, Name = "Rock", ImageLocation="/images/genres/rock_200x220.jpg"},
            new Genre{GenreId = 3, Name = "Trance", ImageLocation="/images/genres/trance_200x220.jpg"}
        };
    }
}
