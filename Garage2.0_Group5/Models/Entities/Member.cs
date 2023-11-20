using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    public class Member
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
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
        [StringLength(12, ErrorMessage = "Person number must be 12 characters long!", MinimumLength = 12)]
        public string PersonNumber { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    }
}
