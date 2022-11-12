using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokedex_API.Database;
using Pokedex_API.Dtos;
using Pokedex_API.Interfaces;
using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public class BaseRepository<T, TDto> : IBaseRepository<T, TDto> where T : BaseEntity, new() where TDto:BaseDto
    {
        private readonly PokedexContext _dbContext;
        private readonly IMapper _mapper;

        private DbSet<T> table;

        public BaseRepository(PokedexContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

            table = _dbContext.Set<T>();
        }

        public async Task<TDto> Create(TDto entityDto)
        {
            var dbEntity = new T();

            _mapper.Map(entityDto, dbEntity);
            await table.AddAsync(dbEntity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<TDto>(dbEntity);            
        }

        public async Task Delete(Guid id)
        {
            var entity = await table.FirstOrDefaultAsync(e => e.Id == id);
            if (entity != null)
            {
                table.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<TDto>> GetAll()
        {
            return _mapper.Map<List<TDto>>(await table.ToListAsync());
        }

        public async Task<TDto> GetById(Guid id)
        {
            return _mapper.Map<TDto>(await table.FirstOrDefaultAsync(e => e.Id == id));
        }

        public async Task<TDto> Update(TDto entityDto)
        {            
            if (entityDto==null)
                throw new NotImplementedException();

            var entity= await table.FirstOrDefaultAsync(e=>e.Id==entityDto.Id);

            _mapper.Map(entityDto,entity);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<TDto>(entity);
        }

    }
}