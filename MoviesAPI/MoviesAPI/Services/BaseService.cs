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
        public virtual async Task<List<DTOModel>> Get(TSearch search)
        {

            var list =  db.Set<TDatabase>().ToList();


            return await Task.FromResult(mapper.Map<List<DTOModel>>(list));
        }

        public virtual async Task<DTOModel> GetById(int id)
        {
            var model = await db.Set<TDatabase>().FindAsync(id);

            return  mapper.Map<DTOModel>(model);
        }
    }
}
