using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class MovieActorController : BaseCRUDController<MovieActorDto, MovieActorDto, MovieActorDto, MovieActorDto>
    {
        public MovieActorController(ICRUDService<MovieActorDto, MovieActorDto, MovieActorDto, MovieActorDto> _service) : base(_service)
        {

        }

    }
}
