using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    public class BaseCrudController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class BaseCRUDController<DTOModel, TSearch, TInsert, TUpdate> : BaseController<DTOModel, TSearch>
        {

            private readonly ICRUDService<DTOModel, TSearch, TInsert, TUpdate> service = null;
            public BaseCRUDController(ICRUDService<DTOModel, TSearch, TInsert, TUpdate> _service) : base(_service)
            {

                service = _service;
            }

            [HttpPost]
            public DTOModel Insert(TInsert insert)
            {

                var result = service.Insert(insert);

                return result;
            }




            [HttpPut("{id}")]
            public ActionResult<DTOModel> Update(int id, TUpdate update)
            {

                var result = service.Update(id, update);

                return result;
            }
            [HttpDelete("{id}")]
            public bool Remove(int id)
            {
                return service.Remove(id);
            }

        }
    }
}
