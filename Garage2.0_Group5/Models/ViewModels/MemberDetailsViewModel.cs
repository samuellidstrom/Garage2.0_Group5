
using Garage2._0_Group5.Models.Entities;

namespace Garage2._0_Group5.Models.ViewModels
{
    public class MemberDetailsViewModel
    {
        public int Id { get; set; }
        public string NameFirstName { get; set; }
        public string NameLastName { get; set; }
        public string Email { get; set; }

        public string PersonNumber { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
