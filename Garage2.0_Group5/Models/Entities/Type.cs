using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Garage2._0_Group5.Models.Entities
{
    #nullable disable
    public class Type
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Vehicle Type")]
        [StringLength(20, MinimumLength = 3)]
        public string TypeOfVehicle { get; set; }

        [Required]
        [DisplayName("Number of Wheels")]
        [Range(0, 18)]
        public int Wheels { get; set; }

        //Foreign key
        public int VehicleId { get; set; }

        //Nav property
        public Vehicle Vehicle { get; set; }
    }
}
