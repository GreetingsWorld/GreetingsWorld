using Microsoft.EntityFrameworkCore;
using GreetingsWorld.Models;
using GreetingsWorld.Enums;
using System.Security.Claims;

namespace GreetingsWorld.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var worlds = new World[]
            {
                new World{name = "Sun", numberGreetings = 2, celestialVariety = BodyType.Star, birthDay = DateTime.Parse("0001-01-01"), funFact = "Hard to look at, Harder to swallow."},
                new World{name = "Mercury", numberGreetings = 0, celestialVariety = BodyType.Rocky_Planet, birthDay = DateTime.Parse("1543-01-15"), funFact = "Since it is half hot and half frozen, some call it 'The Hot Pocket' of the solar System."},
                new World{name = "Venus", numberGreetings = 1, celestialVariety = BodyType.Rocky_Planet, birthDay = DateTime.Parse("1620-03-22"), funFact = "Acid air or something."},
                new World{name = "Earth", numberGreetings = 0, celestialVariety = BodyType.Rocky_Planet, birthDay = DateTime.Parse("1990-09-12"), funFact = "You've probably been here."},
                new World{name = "The Freakin' Moon", numberGreetings = 12, celestialVariety = BodyType.Moon, birthDay = DateTime.Parse("1969-04-20"), funFact = "Thank goodness for this one."},
                new World{name = "Mars", numberGreetings = 5, celestialVariety = BodyType.Rocky_Planet, birthDay = DateTime.Parse("1998-09-01"), funFact = "Contrary to popular belief, Elon Musk actually CAME from here..."},
                new World{name = "Jupiter", numberGreetings = 0, celestialVariety = BodyType.Gas_Giant, birthDay = DateTime.Parse("1543-11-16"), funFact = "It is embarrased everybody stares at its spot."},
                new World{name = "Saturn", numberGreetings = 0, celestialVariety = BodyType.Gas_Giant, birthDay = DateTime.Parse("1543-07-04"), funFact = "The prettiest planet?"},
                new World{name = "Uranus", numberGreetings = 0, celestialVariety = BodyType.Ice_Giant, birthDay = DateTime.Parse("1781-04-26"), funFact = "Favorite movie - Sideways."},
                new World{name = "Neptune", numberGreetings = 0, celestialVariety = BodyType.Ice_Giant, birthDay = DateTime.Parse("1851-09-23"), funFact = "So cold."},
                new World{name = "Pluto", numberGreetings = 0, celestialVariety = BodyType.Whatever_Pluto_Is_Nowadays, birthDay = DateTime.Parse("1930-01-23"), funFact = "(It's a Dwarf Planet last I checked..."},
                new World{name = "Charon", numberGreetings = 0, celestialVariety = BodyType.Moon, birthDay = DateTime.Parse("1978-06-22"), funFact = "I think we called it planet X for a while."},
                new World{name = "Proxima Centauri B", numberGreetings = 0, celestialVariety = BodyType.ExoPlanet, birthDay = DateTime.Parse("2016-08-24"), funFact = "Close, but no cigar."},
                new World{name = "Ton 618", numberGreetings = 0, celestialVariety = BodyType.Black_Hole, birthDay = DateTime.Parse("1957-02-29"), funFact = "Thankfully not so close."},
            };

            context.Worlds.AddRange(worlds);
            context.SaveChanges();

            var users = new User[]
            {
                new User{name = "Ethan Plue", worldsLiked = 4},
                new User{name = "Lor Lyons", worldsLiked = 2},
                new User{name = "PlutoH8er", worldsLiked = 0},
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var comments = new Comment[]
{
                new Comment{worldId = 1, userId = 1, comment = "Aw, lit."},
                new Comment{worldId = 8, userId = 2, comment = "Aw, lit."},
                new Comment{worldId = 3, userId = 2, comment = "Hello, world! (Wow, what a great app. I am glad I can say 'hello' to all the worlds now! :D <3"},
                new Comment{worldId = 11, userId = 3, comment = "BORINNNNGGGGGGGG. I wanna see something BIGGER pl0x!!11!one!1!"}
};

            context.Comments.AddRange(comments);
            context.SaveChanges();

        }
        internal static void Initialize(object context)
        {
            throw new NotImplementedException();
        }
    }
}
