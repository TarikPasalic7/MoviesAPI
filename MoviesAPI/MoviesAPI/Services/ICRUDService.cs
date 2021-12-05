namespace MoviesAPI.Services
{
    public interface ICRUDService<DTOModel, TSearch, TInsert, TUpdate> : IService<DTOModel, TSearch>
    {
        DTOModel Insert(TInsert request);

        DTOModel Update(int id, TUpdate request);

        bool Remove(int id);


    }
}
