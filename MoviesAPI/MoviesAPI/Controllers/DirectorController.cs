using Dtos;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;
using static MoviesAPI.Controllers.BaseCrudController;

namespace MoviesAPI.Controllers
{
    public class DirectorController : BaseCRUDController<DirectorDto, DirectorDto, DirectorDto, DirectorDto>
    {
        public DirectorController(ICRUDService<DirectorDto, DirectorDto, DirectorDto, DirectorDto> _service) : base(_service)
        {

        }

    }
}
