using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetingsWorld.Models
{
    public class FacilityPatient
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("facilityId")]
        public int facilityId { get; set; }
        [ForeignKey("facilityName")]
        public string facilityName { get; set; }
        [ForeignKey("facilityState")]
        public string facilityState { get; set; }

        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
    }
}
