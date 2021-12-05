using Dtos;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class MovieGenreController : BaseCRUDController<MovieGenreDto, MovieGenreDto, MovieGenreDto, MovieGenreDto>
    {
        public MovieGenreController(ICRUDService<MovieGenreDto, MovieGenreDto, MovieGenreDto, MovieGenreDto> _service) : base(_service)
        {

        }

    }
}
