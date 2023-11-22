using System.Drawing;

namespace Garage2._0_Group5.Models.ViewModels
{
    public class VehicleDetailsViewModel
    {
        public string LicenseNumber { get; set; }
        public Color Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TypeOfVehicle { get; set; }
        public int Wheels { get; set; }
        public DateTime TimeOfRegistration { get; set; } = DateTime.Now;
    }
}
