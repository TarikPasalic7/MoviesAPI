using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Models
{
    public class MovieActor
    {
        [Key]
        public int MovieActorId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        [ForeignKey("Actor")]
        public int GenreId { get; set; }
        public Movie? Genre { get; set; }

    }
}
