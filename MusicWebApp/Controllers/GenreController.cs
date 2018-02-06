using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicWebApp.Models;
using MusicWebApp.Models.Interfaces;
using MusicWebApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicWebApp.Controllers
{
    public class GenreController : Controller
    {
        private readonly ITrackRepository _trackRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IPlaylistRepository _playlistRepository;

        public GenreController(ITrackRepository trackRepository, IGenreRepository genreRepository,
            IArtistRepository artistRepository, IPlaylistRepository playlistRepository)
        {
            _trackRepository = trackRepository;
            _genreRepository = genreRepository;
            _artistRepository = artistRepository;
            _playlistRepository = playlistRepository;
        }

        public ViewResult List()
        {
            var genresViewModel = new GenresListViewModel();
            genresViewModel.Genres = _genreRepository.Genres;
            return View(genresViewModel);
        }
    }
}
