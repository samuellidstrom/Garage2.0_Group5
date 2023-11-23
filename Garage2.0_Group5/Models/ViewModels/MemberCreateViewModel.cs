using Garage2._0_Group5.Validations;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.ViewModels
{
#nullable disable
    public class MemberCreateViewModel
    {
        [Required]
        public string NameFirstName { get; set; }


        [Required]
        //[CheckName]
        public string NameLastName { get; set; }


        //[Required(ErrorMessage = "Email is required")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        [Required]
        [RegularExpression(@"^(?<date>\d{8})[-\s]?\d{4}$", ErrorMessage = "Person Number format must be YYYYMMDDNNNN")]
        [CheckAge]
        public string PersonNumber { get; set; }
    }
}
