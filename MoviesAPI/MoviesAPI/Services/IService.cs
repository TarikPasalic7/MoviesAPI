namespace MoviesAPI.Services
{
   
        public interface IService<DTOModel, TSearch>
        {

            List<DTOModel> Get(TSearch search);

            DTOModel GetById(int id);


        }
    
}
