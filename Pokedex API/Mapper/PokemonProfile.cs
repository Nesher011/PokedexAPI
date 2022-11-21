using AutoMapper;
using Pokedex_API.Dtos;
using Pokedex_API.Models;

namespace Pokedex_API.Mapper
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<PokemonDto, Pokemon>().ReverseMap();
        }
    }
}