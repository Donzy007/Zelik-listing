using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zelik.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name="Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name="Number of Stock")]
        public byte NumberInStock { get; set; }

        [Display(Name="Added Date")]
        public DateTime DateAdded { get; set; }

        
        public Genre Genre { get; set; }

        [Display(Name ="Genre")]
      
        public byte GenreId { get; set; }
    }
}