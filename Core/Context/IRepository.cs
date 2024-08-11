namespace Core.Context
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByKey(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> Update(T entidad);
        Task<bool> Create(T entidad);
        Task<bool> HardDelete(int id);
    }
}
