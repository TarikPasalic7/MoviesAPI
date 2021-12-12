using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class InsertMovieActorDto
    {
        public int MovieActorId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
    }
}
