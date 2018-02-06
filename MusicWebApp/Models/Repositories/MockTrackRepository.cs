using System;
using System.Collections.Generic;
using System.Linq;
using MusicWebApp.Models.Interfaces;

namespace MusicWebApp.Models.Repositories
{
    public class MockTrackRepository : ITrackRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();
        private readonly IArtistRepository _artistRepository = new MockArtistRepository();

        public IEnumerable<Track> Tracks
        {
            get
            {
                var tracks = new List<Track>
                {
                    new Track {TrackId = 1, Title = "Crazy", Size = 4650}, // rock
                    new Track{TrackId = 2, Title = "I don't wanna miss a thing", Size = 7800}, // rock
                    new Track{TrackId = 3, Title = "Sweet suffering",  Size = 12400, Rating = 4}, // chillout
                    new Track{TrackId = 4, Title = "The other side", Size = 11500, Rating = 5}, // trance
                    new Track{TrackId = 5, Title = "Crush", Size = 9800} // trance
                };

                for (var i = 0; i < tracks.Count; i++)
                {
                    var track = tracks[i];
                    var id = track.TrackId;
                    int genreId = 0;
                    Genre genre;
                    int artistId = 0;
                    Artist artist;
                    switch (id)
                    {
                        case 1:
                            genreId = 2;
                            artistId = 2;
                            break;
                        case 2:
                            genreId = 2;
                            artistId = 2;
                            break;
                        case 3:
                            genreId = 1;
                            artistId = 1;
                            break;
                        case 4:
                            genreId = 3;
                            artistId = 3;
                            break;
                        case 5:
                            genreId = 3;
                            artistId = 3;
                            break;
                    }
                    genre = _genreRepository.Genres.FirstOrDefault(g => g.GenreId == genreId);
                    artist = _artistRepository.Artists.FirstOrDefault(a => a.ArtistId == artistId);
                    track.Genre = genre;
                    track.Artist = artist;
                }

                return tracks;
            }
        }

        public IEnumerable<Track> FavouriteTracks => Tracks.Where(t => t.Rating >= 4);
        public Track GetTrackById(int trackId) => Tracks.FirstOrDefault(t => t.TrackId == trackId);
    }
}
