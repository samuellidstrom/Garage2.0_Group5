using Garage2._0_Group5.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    //#nullable disable
    public class Member
    {
        public int Id { get; set; }


        public Name Name { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [StringLength(50, MinimumLength = 7)]
        public string Email { get; set; }


        [Required]
        //[RegularExpression(@"^(?<date>\d{8})[-\s]?\d{4}$", ErrorMessage = "Person Number format must be YYYYMMDDNNNN")]
        [Remote(action: "UniquePersonNumber", controller: "Members")]
        [CheckAge]
        [DisplayName("Person Number")]
        [StringLength(12, MinimumLength = 12)]
        public string PersonNumber { get; set; }


        //Navigation Property
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        public ICollection<VehicleType> VehicleTypes { get; set; }

        //public Member(string firstName, string lastName, string email, string personNumber, ICollection<Vehicle> vehicles, ICollection<VehicleType> vehicleTypes)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    PersonNumber = personNumber;
        //    Vehicles = vehicles;
        //    VehicleTypes = vehicleTypes;
        //}
        private Member()
        {
            Name = null!;
            Email = null!;
            PersonNumber = null!;
        }

        public Member(Name name, string email, string personNumber)
        {
            Name = name;
            Email = email;
            PersonNumber = personNumber;
        }
    }
}
