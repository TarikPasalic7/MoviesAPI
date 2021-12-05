using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class MovieController : BaseCRUDController<MovieDto, MovieDto, MovieDto, MovieDto>
    {
        public MovieController(ICRUDService<MovieDto, MovieDto, MovieDto, MovieDto> _service) : base(_service)
        {

        }

    }
}
