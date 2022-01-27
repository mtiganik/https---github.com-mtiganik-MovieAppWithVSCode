using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }

        public string? Description {get;set;}

        [Range(0,100)]
        public int Rating {get;set;}

        [Display(Name = "Year of Release")]
        [Range(1900,2030)]
        public int Year { get; set; }
        
        public int CategoryId{get; set;}


        public Category? Category{get;set;}

    }
}