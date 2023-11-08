using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Garage2._0_Group5.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public TypeOfVehicle Type { get; set; }


        private string licenseNumber;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("License Number")]
        [RegularExpression(@"^[a-zA-Z]{3}\d{3}$", ErrorMessage = "Registration format must be ABC123")]
        [StringLength(6, MinimumLength = 6)]
        [Key]
        public string LicenseNumber { get 
            {
                return licenseNumber;
            }
            set
            {
                licenseNumber = Regex.Replace(value, @"\s", "").ToUpper();
            }
        }

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

        [DisplayName("Time of Registration")]
        public DateTime? TimeOfRegistration { get; set; }

        public Vehicle()
        {
            TimeOfRegistration = DateTime.Now;
        }
    }
}
