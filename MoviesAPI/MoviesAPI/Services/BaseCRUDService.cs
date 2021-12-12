using AutoMapper;
using MoviesAPI.Data;

namespace MoviesAPI.Services
{
    public class BaseCRUDService<DTOModel, TSearch, TDatabase, TInsert, TUptade> : BaseService<DTOModel, TSearch, TDatabase>, ICRUDService<DTOModel, TSearch, TInsert, TUptade> where TDatabase : class
    {
      
        public BaseCRUDService(MovieContext _db, IMapper m) : base(_db, m)
        {
          
        }



        public virtual DTOModel Insert(TInsert request)
        {

            var entity = mapper.Map<TDatabase>(request);


            //db.Set<TDatabase>().Add(k);
            db.Add(entity);
            db.SaveChanges();
            return mapper.Map<DTOModel>(entity);
        }

        public bool Remove(int id)
        {
            var entity = db.Set<TDatabase>().Find(id);
            if (entity != null)
            {
                db.Set<TDatabase>().Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public virtual DTOModel Update(int id, TUptade request)
        {
            var entity = db.Set<TDatabase>().Find(id);
            mapper.Map(request, entity);


            db.SaveChanges();
           




            return mapper.Map<DTOModel>(entity);
        }
    }
}
