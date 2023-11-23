
using Garage2._0_Group5.Models.ViewModels;
using Garage2._0_Group5.Validations;
using System.ComponentModel.DataAnnotations;

namespace Garage3._0.Web.Models.ViewModels
{
#nullable disable
    public class MemberCreateViewModel : IMemberViewModel
    {
        //[Required]
        public string FirstName { get; set; }


        //[Required]
        //[CheckName]
        public string LastName { get; set; }


        //[Required(ErrorMessage = "Email is required")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        //[Required]
        //[RegularExpression(@"^(?<date>\d{8})[-\s]?\d{4}$", ErrorMessage = "Person Number format must be YYYYMMDDNNNN")]
        //[CheckAge]
        public string PersonNumber { get; set; }
    }
}
