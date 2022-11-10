using Pokedex_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using Pokedex_API.Database;
using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly PokedexContext _dbContext;

        public BaseRepository(PokedexContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Create(T entity)
        {
            if (entity == null)
                throw new NotImplementedException();

            await _dbContext.SaveChangesAsync();

            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}