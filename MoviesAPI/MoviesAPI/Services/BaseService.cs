using AutoMapper;
using MoviesAPI.Data;

namespace MoviesAPI.Services
{
    public class BaseService<DTOModel, TSearch, TDatabase> : IService<DTOModel, TSearch> where TDatabase : class
    {

        protected readonly MovieContext db;
        protected readonly IMapper mapper;
        public BaseService(MovieContext _db, IMapper m)
        {
            db = _db;
            mapper = m;
        }
        public virtual List<DTOModel> Get(TSearch search)
        {

            var list = db.Set<TDatabase>().ToList();


            return mapper.Map<List<DTOModel>>(list);
        }

        public virtual DTOModel GetById(int id)
        {
            var model = db.Set<TDatabase>().Find(id);

            return mapper.Map<DTOModel>(model);
        }
    }
}
