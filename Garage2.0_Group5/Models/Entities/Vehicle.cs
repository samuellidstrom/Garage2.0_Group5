using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Garage2._0_Group5.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        //private string licenseNumber;

        [Required]
        [DisplayName("License Number")]
        [RegularExpression(@"^[a-zA-Z]{3}\d{3}$", ErrorMessage = "Registration format must be ABC123")]
        [StringLength(6, MinimumLength = 6)]
        [Remote(action: "UniqueLicenseNumber", controller: "Vehicles")]
        public string LicenseNumber { get; set; }
        //{
        //    get
        //    {
        //        return licenseNumber;
        //    }
        //    set
        //    {
        //        licenseNumber = Regex.Replace(value, @"\s", "").ToUpper();
        //    }
        //}

        [DisplayName("Color")]
        public Color Color { get; set; }

        [Required]
        [DisplayName("Brand")]
        [StringLength(15, MinimumLength = 3)]
        public string Brand { get; set; }

        [Required]
        [DisplayName("Model")]
        [StringLength(15, MinimumLength = 3)]
        public string Model { get; set; }

        [DisplayName("Check-in Time")]
        public DateTime TimeOfRegistration { get; set; }

        //ToDo: Fix so this doesn't change when vechiel is edited
        public Vehicle()
        {
            TimeOfRegistration = DateTime.Now;
        }




        //[Required]
        //[DisplayName("Number of Wheels")]
        //[Range(0, 18)]
        //public int NoOfWheels { get; set; }






























        // Added by Samuel - Relationship with Type-class
        //Nav prop
        public Type VehicleType { get; set; }


    }
}
