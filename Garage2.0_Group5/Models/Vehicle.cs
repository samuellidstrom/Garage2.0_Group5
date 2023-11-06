using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string LicenseNumber { get; set; }

        [Required]
        [DisplayName("Color")]
        [StringLength(10, MinimumLength = 3)]
        public string Color { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public DateTime? TimeOfRegistration { get; set; }

        public Vehicle()
        {
            TimeOfRegistration = DateTime.Now;
        }

    }

}
