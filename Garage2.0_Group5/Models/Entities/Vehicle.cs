using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public TypeOfVehicle Type { get; set; }

        [DisplayName("License Number")]
        public string LicenseNumber { get; set; }

        public Color Color { get; set; }

        [Required]
        [DisplayName("Brand")]
        [StringLength(15, MinimumLength = 3)]
        public string Brand { get; set; }

        [Required]
        [DisplayName("Model")]
        [StringLength(15, MinimumLength = 3)]
        public string Model { get; set; }

        [Required]
        [DisplayName("Number of Wheels")]
        [Range(0, 18)]
        public int NoOfWheels { get; set; }

        [DisplayName("Check in Time")]
        public DateTime? TimeOfRegistration { get; set; }

        public Vehicle()
        {
            TimeOfRegistration = DateTime.Now;
        }
    }
}
