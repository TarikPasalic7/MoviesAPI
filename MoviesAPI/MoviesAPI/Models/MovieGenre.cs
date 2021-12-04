using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Models
{
    public class MovieGenre
    {
        [Key]
        public int MovieGenreId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public Movie? Genre { get; set; }


    }
}
