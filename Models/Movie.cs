using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        [Display(Name = "Relase Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public required string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string? Rating { get; set; }

    }
}