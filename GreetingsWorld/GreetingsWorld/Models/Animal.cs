using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class Animal
    {
        [Key]
        public int animalId { get; set; }
        public string species { get; set; }
    }
}
