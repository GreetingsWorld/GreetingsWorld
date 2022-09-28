using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class Facility
    {
        [Key]
        public int facilityId { get; set; }
        public string facilityName { get; set; }
        public string facilityState{ get; set; }

    }
}
