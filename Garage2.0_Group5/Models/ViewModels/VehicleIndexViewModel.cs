using Garage2._0_Group5.Models.Entities;

namespace Garage2._0_Group5.Models.ViewModels    
{
    public class VehicleIndexViewModel
    {
#nullable disable
        public int Id { get; set; }
        public string LicenseNumber { get; set; }    
        public string TypeOfVehicle { get; set; }
        public DateTime TimeOfRegistration { get; set; } = DateTime.Now;
    }
}
