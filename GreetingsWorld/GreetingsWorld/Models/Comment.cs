using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class Comment
    {
        [Key]
        public int worldId { get; set; }
        public virtual World world { get; set; }
        [Key]
        public int userId { get; set; }
        public virtual User commenter { get; set; }
        public string comment { get; set; }
    }
}
