using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class DbGenreRepository : IGenreRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbGenreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Genre> Genres => _appDbContext.Genres;
    }
}
