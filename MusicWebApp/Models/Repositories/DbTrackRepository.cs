using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class DbTrackRepository : ITrackRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbTrackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Track> Tracks => _appDbContext.Tracks;

        public IEnumerable<Track> FavouriteTracks
        {
            get { return _appDbContext.Tracks.Where(track => track.Rating >= 4); }
        }
        public Track GetTrackById(int trackId)
        {
            return _appDbContext.Tracks.FirstOrDefault(t => t.TrackId == trackId);
        }
    }
}
