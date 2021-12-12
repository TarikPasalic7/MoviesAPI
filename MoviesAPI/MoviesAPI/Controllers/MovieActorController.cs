using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class MovieActorController : BaseCRUDController<MovieActorDto, MovieActorDto, InsertMovieActorDto, MovieActorDto>
    {
        public MovieActorController(ICRUDService<MovieActorDto, MovieActorDto, InsertMovieActorDto, MovieActorDto> _service) : base(_service)
        {

        }

    }
}
