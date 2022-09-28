using GreetingsWorld.Data;
using GreetingsWorld.Enums;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetingsWorld.Models
{
    public class World
    {
        [Key]
        public int worldId { get; set; }
        public string name { get; set; }
        public int numberGreetings { get; set; }
        public BodyType celestialVariety { get; set; }
        public DateTime birthDay { get; set; }
        public string funFact { get; set; }
        public List<Comment?> comments { get; set; }

        public string TypeToString(BodyType cVariety)
        {
            Dictionary<BodyType, string> deptDict = new Dictionary<BodyType, string>()
        {
            {BodyType.None, "N/A"},
            {BodyType.Star, "Star"},
            {BodyType.Rocky_Planet, "Rocky Planet"},
            {BodyType.Liquid_Planet, "Liquid Planet"},
            {BodyType.Moon, "Moon"},
            {BodyType.Gas_Giant, "Gas Giant"},
            {BodyType.Ice_Giant, "Ice Giant"},
            {BodyType.ExoPlanet, "ExoPlanet"},
            {BodyType.Whatever_Pluto_Is_Nowadays, "Whatever Pluto is Nowadays"},
            {BodyType.Black_Hole, "Black Hole!!!!!"},
        };

            if (deptDict.ContainsKey(cVariety))
            {
                return deptDict[cVariety];
            }
            throw new TypeNotFound();
        }
    }
}