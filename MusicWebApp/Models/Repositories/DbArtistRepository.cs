using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class DbArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbArtistRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Artist> Artists => _appDbContext.Artists;
    }
}
