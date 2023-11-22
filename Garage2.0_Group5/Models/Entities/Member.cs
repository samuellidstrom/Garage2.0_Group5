using Garage2._0_Group5.Validations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
#nullable disable
    public class Member
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }


        [Required]
        [CheckNameAttribute]
        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }


        [DisplayName("Owner")]
        public string FullName => $"{FirstName} {LastName}";


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

    }
}
