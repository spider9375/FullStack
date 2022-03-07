using Backend.Interfaces;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [Route("")]
        [ProducesResponseType(typeof(List<RecipeDto>), 200)]
        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            var recipes = this.recipeService.GetAllRecipes();

            return this.Ok(recipes);
        }
    }
}
