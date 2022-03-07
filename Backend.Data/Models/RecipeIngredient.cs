using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Data.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        [ForeignKey("Ingredient")]
        public int IngredientId { get; set; }

        public double Amount { get; set; }

        public string UnitOfMeasure { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
