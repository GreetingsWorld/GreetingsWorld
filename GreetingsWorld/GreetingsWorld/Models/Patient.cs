using System.ComponentModel.DataAnnotations;

namespace GreetingsWorld.Models
{
    public class Patient
    {
        [Key]
        public int patientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
