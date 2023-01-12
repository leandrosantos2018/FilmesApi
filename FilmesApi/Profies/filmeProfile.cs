using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profies
{
    public class filmeProfile : Profile
    {
        public filmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
        }
    }
}
