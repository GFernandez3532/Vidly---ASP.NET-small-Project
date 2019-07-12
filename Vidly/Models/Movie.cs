using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Released")]
        public DateTime ReleaseDate { get; set; }


        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name="Number in stock")]
        public byte NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}
