using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieCategoryViewModel
    {
        public IQueryable<Movie>? Movies { get; set; }
        public SelectList? Categories { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}