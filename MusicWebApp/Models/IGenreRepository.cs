using System.Collections.Generic;

namespace MusicWebApp.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Genres { get; }
    }
}