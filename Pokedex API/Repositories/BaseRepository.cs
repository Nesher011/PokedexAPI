using Pokedex_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using Pokedex_API.Database;
using Pokedex_API.Models;
using Pokedex_API.Dtos;

namespace Pokedex_API.Repositories
{
    public class BaseRepository<T, TDto> : IBaseRepository<T, TDto> where T : BaseEntity, new() where TDto:BaseDto
    {
        private readonly PokedexContext _dbContext;
        private DbSet<T> table;

        public BaseRepository(PokedexContext dbContext)
        {
            _dbContext = dbContext;

            table = _dbContext.Set<T>;
        }

        public async Task<T> Create(TDto entityDto)
        {
            var entityFromDb = new T();

            if (entity == null)
                throw new NotImplementedException();

            var entityFromDb = await table.FirstOrDefaultAsync(e => e.Id == entityDto.Id);
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