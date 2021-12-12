using Dtos;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class MovieGenreController : BaseCRUDController<MovieGenreDto, MovieGenreDto, InsertMovieGenreDto, MovieGenreDto>
    {
        public MovieGenreController(ICRUDService<MovieGenreDto, MovieGenreDto, InsertMovieGenreDto, MovieGenreDto> _service) : base(_service)
        {

        }

    }
}
