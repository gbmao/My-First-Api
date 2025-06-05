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

        public DateOnly ReleaseDAte { get; set; }
    }
}
