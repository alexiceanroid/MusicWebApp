using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWebApp.Models;

namespace MusicWebApp.ViewModels
{
    public class GenresListViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
    }
}
