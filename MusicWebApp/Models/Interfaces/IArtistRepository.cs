using System.Collections.Generic;

namespace MusicWebApp.Models.Interfaces
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> Artists { get; }
    }
}