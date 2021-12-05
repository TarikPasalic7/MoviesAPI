using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;

using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
  
        //[Authorize]
        public class ActorController : BaseCRUDController<ActorDto, ActorDto, ActorDto, ActorDto>
        {
            public ActorController(ICRUDService<ActorDto, ActorDto, ActorDto, ActorDto> _service) : base(_service)
            {

            }

        }
    
}
