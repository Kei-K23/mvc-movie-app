using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public required string Genre {get; set;}
        public decimal Price {get; set;}

    }
}