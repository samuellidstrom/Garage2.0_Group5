using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }

        public VehicleType VehicleType { get; set; }

        [Required]
        [DisplayName("Registration Number")]
        [RegularExpression(@"^[a-zA-Z]{3}\d{3}$", ErrorMessage = "Registration number format must be ABC123")]
        [StringLength(6, MinimumLength = 6)]
        public string RegistrationNumber { get; set; }

        [Required]
        [DisplayName("Color")]
        [StringLength(15, MinimumLength = 3)]
        public string Color { get; set; }

        [Required]
        [DisplayName("Car Brand")]
        [StringLength(40, MinimumLength = 2)]
        public string Brand { get; set; }

        [Required]
        [DisplayName("Car Model")]
        [StringLength(20, MinimumLength = 2)]
        public string Model { get; set; }

        [Required]
        [DisplayName("Number of Wheels")]
        [Range(0, 18)]
        public int NumberOfWheels { get; set; }

        [Required]
        [DisplayName("Car's Time of Arrival")]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public Customer Customer { get; set; }

    }
}
