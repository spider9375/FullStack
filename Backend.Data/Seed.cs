using Backend.Data.Models;

namespace Backend.Data
{
    public class Seed
    {
        static void Main(string[] args)
        {
            using (var db = new RecipeContext())
            {
                var ingredient = db.Ingredients.Add(new Ingredient
                {
                    Id = 1,
                    Name = "Egg"
                });

                var recipe = db.Recipes.Add(new Recipe { Name = "Mashed eggs", });

                db.RecipeIngredients.Add(new RecipeIngredient
                {
                    Recipe = recipe,
                    Ingredient = ingredient,
                    Amount = 2,
                    UnitOfMeasure = "number"
                });

                db.SaveChanges();
            }
        }
    }
}