using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class DbPlaylistRepository : IPlaylistRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbPlaylistRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Playlist> Playlists => _appDbContext.Playlists;
    }
}
