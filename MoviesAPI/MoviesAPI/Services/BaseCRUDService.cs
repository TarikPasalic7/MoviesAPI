using AutoMapper;
using MoviesAPI.Data;

namespace MoviesAPI.Services
{
    public class BaseCRUDService<DTOModel, TSearch, TDatabase, TInsert, TUptade> : BaseService<DTOModel, TSearch, TDatabase>, ICRUDService<DTOModel, TSearch, TInsert, TUptade> where TDatabase : class
    {
      
        public BaseCRUDService(MovieContext _db, IMapper m) : base(_db, m)
        {
          
        }



        public virtual async  Task<DTOModel> Insert(TInsert request)
        {

            var entity = mapper.Map<TDatabase>(request);


            //db.Set<TDatabase>().Add(k);
            await db.AddAsync(entity);
            await db.SaveChangesAsync();
            return mapper.Map<DTOModel>(entity);
        }

        public async Task<bool>  Remove(int id)
        {
            var entity = db.Set<TDatabase>().Find(id);
            if (entity != null)
            {
                db.Set<TDatabase>().Remove(entity);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public virtual async Task<DTOModel> Update(int id, TUptade request)
        {
            var entity =   await db.Set<TDatabase>().FindAsync(id);
            mapper.Map(request, entity);


            await db.SaveChangesAsync();
           




            return mapper.Map<DTOModel>(entity);
        }
    }
}
