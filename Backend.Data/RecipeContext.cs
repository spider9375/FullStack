using Backend.Data.Models;
using System.Data.Entity;

namespace Backend.Data
{
    public class RecipeContext : DbContext, IRecipeContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
