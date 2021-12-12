using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class MovieGenreDto
    {
       
        public int MovieGenreId { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public string? Title { get; set; }


        public string? Genre { get; set; }
        public float Rating { get; set; }

        public string? Plot { get; set; }

        public DateTime? MovieLength { get; set; }

    }
}
