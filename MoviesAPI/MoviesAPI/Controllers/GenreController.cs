using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class GenreController : BaseCRUDController<GenreDto, GenreDto, GenreDto, GenreDto>
    {
        public GenreController(ICRUDService<GenreDto, GenreDto, GenreDto, GenreDto> _service) : base(_service)
        {

        }

    }
}