using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Garage2._0_Group5.Models.Entities
{
    //#nullable disable
    public class Vehicle
    {

        private string licenseNumber;

        //[Required]
        [DisplayName("License Number")]
        [RegularExpression(@"^[a-zA-Z]{3}\d{3}$", ErrorMessage = "Registration format must be ABC123")]
        [StringLength(6, MinimumLength = 6)]
        [Remote(action: "UniqueLicenseNumber", controller: "Vehicles")]
        public string LicenseNumber
        {
            get
            {
                return licenseNumber;
            }
            set
            {
                licenseNumber = Regex.Replace(value, @"\s", "").ToUpper();
            }
        }


        [DisplayName("Color")]
        public Color Color { get; set; }

        //[Required]
        [DisplayName("Brand")]
        [StringLength(15, MinimumLength = 3)]
        public string Brand { get; set; }

        //[Required]
        [DisplayName("Model")]
        [StringLength(15, MinimumLength = 3)]
        public string Model { get; set; }

        [DisplayName("Check-in Time")]
        public DateTime TimeOfRegistration { get; set; }


        public int MemberId { get; set; }
        public int VehicleTypeId { get; set; }

        public Member Member { get; set; }
        public VehicleType VehicleType { get; set; }


    }
}
