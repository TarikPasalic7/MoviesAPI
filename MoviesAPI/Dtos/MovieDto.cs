using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class MovieDto
    {
        
        public int Id { get; set; }

       
        public int DirectorID { get; set; }
    

        public string? Title { get; set; }

      

        public float Rating { get; set; }

        public string? Plot { get; set; }

        public DateTime? MovieLength { get; set; }

    }
}
