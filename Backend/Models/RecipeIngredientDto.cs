﻿namespace Backend.Models
{
    public class RecipeIngredientDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public string UnitOfMeasure { get; set; }
    }
}
