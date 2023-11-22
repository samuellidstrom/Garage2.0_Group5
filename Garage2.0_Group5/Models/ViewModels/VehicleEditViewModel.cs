using Garage2._0_Group5.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.ViewModels
{
#nullable disable
    public class VehicleEditViewModel
    {
        [Required]
        [Display(Name = "Member")]
        public MemberViewModel Member { get; set; }

        public int Id { get; }
        public string LicenseNumber { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TypeOfVehicle { get; set; }
        public int Wheels { get; set; }
        public DateTime TimeOfRegistration { get; }
    }
}
