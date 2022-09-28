using GreetingsWorld.Enums;
using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class World
    {
        public int worldId { get; set; }
        public string name { get; set; }
        public int numberGreetings { get; set; }
        public BodyType celestialVariety { get; set; }
        public DateTime birthDay { get; set; }
        public string funFact { get; set; }
        public List<string?> comments { get; set; }
    }
}
