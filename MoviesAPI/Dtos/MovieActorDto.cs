using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class MovieActorDto
    {

        
        public int MovieActorId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Nationallity { get; set; }

        public DateTime Birth { get; set; }
        public int DirectorID { get; set; }


        public string? Title { get; set; }



        public float Rating { get; set; }

        public string? Plot { get; set; }

        public DateTime? MovieLength { get; set; }

    }
}
