namespace Garage2._0_Group5.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}