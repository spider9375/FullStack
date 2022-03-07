using Backend.Models;

namespace Backend.Interfaces
{
    public interface IRecipeService
    {
        public List<RecipeDto> GetAllRecipes();
    }
}
