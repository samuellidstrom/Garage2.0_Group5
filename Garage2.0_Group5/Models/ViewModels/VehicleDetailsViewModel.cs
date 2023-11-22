using Garage2._0_Group5.Models.Entities;
using System.Drawing;
#nullable disable
namespace Garage2._0_Group5.Models.ViewModels
{
    public class VehicleDetailsViewModel
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public VehicleColor VehicleColor{ get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TypeOfVehicle { get; set; }
        public int Wheels { get; set; }
        public DateTime TimeOfRegistration { get; set; }
    }
}
