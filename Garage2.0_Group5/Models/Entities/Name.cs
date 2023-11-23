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
        //[CheckNameAttribute]
        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }


        [DisplayName("Owner")]
        public string FullName => $"{FirstName} {LastName}";

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
