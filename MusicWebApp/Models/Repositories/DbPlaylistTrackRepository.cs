using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class DbPlaylistTrackRepository : IPlaylistTrackRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbPlaylistTrackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PlaylistTrack> PlaylistTracks => _appDbContext.PlaylistTracks;
    }
}
