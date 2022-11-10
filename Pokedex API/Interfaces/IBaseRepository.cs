using Pokedex_API.Models;

namespace Pokedex_API.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task<T> GetById(Guid guid);

        Task Delete(Guid guid);

        Task<T> GetById(int id);
    }
}