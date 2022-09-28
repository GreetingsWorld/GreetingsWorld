using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetingsWorld.Models
{
    public class Comment
    {
        [Key, Column(Order = 0)]
        public int worldId { get; set; }
        public virtual World world { get; set; }
        [Key, Column(Order = 1)]
        public int userId { get; set; }
        public virtual User commenter { get; set; }
        [Required]
        public string comment { get; set; }
    }
}