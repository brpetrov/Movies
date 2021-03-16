using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedToDatabase { get; set; }

        [Required]
        [Range(1, 50)]
        public int NumberInStock { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
    }
}