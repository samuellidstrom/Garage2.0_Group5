using Garage2._0_Group5.Validations;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.ViewModels
{
#nullable disable
    public class MemberEditViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PersonNumber { get; set; }

    }
}
