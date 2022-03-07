using System.ComponentModel.DataAnnotations;

namespace Backend.Data.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
