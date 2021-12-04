using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Nationallity { get; set; }

        public DateTime Birth { get; set; }

    }
}
