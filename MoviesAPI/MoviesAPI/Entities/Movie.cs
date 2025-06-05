using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength (40)]
        public required string Name { get; set; }

        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }

        //navigation property
        [ValidateNever] 
        public Genre? Genre { get; set; }
        //foreign Key property
        public int GenreId { get; set; }

        public DateOnly ReleaseDAte { get; set; }
    }
}
