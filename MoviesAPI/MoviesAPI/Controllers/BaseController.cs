using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<DTOModel, TSearch> : ControllerBase
    {

        private readonly IService<DTOModel, TSearch> service;


        public BaseController(IService<DTOModel, TSearch> _service)
        {
            service = _service;


        }


        //Get Autor
        [HttpGet]
        public ActionResult<List<DTOModel>> get([FromQuery] TSearch search)
        {
            var list = service.Get(search);

            return Ok(list);
        }


        //Get AutorbyID
        [HttpGet("{id}")]
        public ActionResult<DTOModel> GetById(int id)
        {
            return service.GetById(id);

        }


    }
}
