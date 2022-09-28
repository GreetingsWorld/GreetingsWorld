using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string name { get; set; }
        public int? worldsLiked { get; set; }
    }
}
