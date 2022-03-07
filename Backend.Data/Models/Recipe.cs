using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Data.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
