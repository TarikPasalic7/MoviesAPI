using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Director")]
        public int DirectorID { get; set; }
        public Director? Director { get; set; }

        public string? Title { get; set; }

        public DateTime   ReleaseYear { get; set; }

        public float Rating { get; set; }

        public string? Plot { get; set; }

        public int MovieLength { get; set; }

    }
}
