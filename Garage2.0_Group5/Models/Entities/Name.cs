using Garage2._0_Group5.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    public class Name
    {
        [Required]
        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }


        [Required]
        [CheckName]
        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }


        [DisplayName("Owner")]
        public string FullName => $"{FirstName} {LastName}";

        private Name()
        {
            FirstName = null!;
            LastName = null!;
        }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
