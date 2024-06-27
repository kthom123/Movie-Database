using System;
using System.ComponentModel.DataAnnotations;

namespace Movie_Database.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }
    }
}
