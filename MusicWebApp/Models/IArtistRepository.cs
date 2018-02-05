using System.Collections.Generic;

namespace MusicWebApp.Models
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> Artists { get; }
    }
}