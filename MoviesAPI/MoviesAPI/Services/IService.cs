namespace MoviesAPI.Services
{
   
        public interface IService<DTOModel, TSearch>
        {

            Task <List<DTOModel>> Get(TSearch search);

            Task<DTOModel> GetById(int id);


        }
    
}
