namespace MoviesAPI.Services
{
    public interface ICRUDService<DTOModel, TSearch, TInsert, TUpdate> : IService<DTOModel, TSearch>
    {
         Task<DTOModel> Insert(TInsert request);

        Task<DTOModel> Update(int id, TUpdate request);

        Task<bool> Remove(int id);


    }
}
