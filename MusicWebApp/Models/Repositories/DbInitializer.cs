using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MusicWebApp.ViewModels;

namespace MusicWebApp.Models.Repositories
{
    public class DbInitializer
    {
        

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var ctx = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!ctx.Genres.Any())
            {
                var genreRepo = new MockGenreRepository();
                ctx.Genres.AddRange( genreRepo.Genres);
            }
            if (!ctx.Artists.Any())
            {
                var artistRepo = new MockArtistRepository();
                ctx.Artists.AddRange(artistRepo.Artists);
            }
            if (!ctx.Tracks.Any())
            {
                var trackRepo = new MockTrackRepository();
                ctx.Tracks.AddRange(trackRepo.Tracks);
            }

            ctx.SaveChanges();
        }

        
    }
}
