using AutoMapper;
using Backend.Data.Models;
using Backend.Models;

namespace Backend
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RecipeDto, Recipe>();
            CreateMap<Recipe, RecipeDto>();
        }
    }
}
