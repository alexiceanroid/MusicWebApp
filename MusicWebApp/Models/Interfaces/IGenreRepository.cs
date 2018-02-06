using System.Collections.Generic;

namespace MusicWebApp.Models.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Genres { get; }
    }
}