using AutoMapper;
using Backend.Data;
using Backend.Interfaces;
using Backend.Models;

namespace Backend.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeContext Db;
        private readonly IMapper mapper;


        public RecipeService(IMapper mapper)
        {
            this.Db = new RecipeContext();
            this.mapper = mapper;
        }

        public List<RecipeDto> GetAllRecipes()
        {
            var recipes = this.Db.Recipes.ToList();

            var mapped = recipes.Select(x => this.mapper.Map<RecipeDto>(x)).ToList();

            return mapped;
        }
    }
}
