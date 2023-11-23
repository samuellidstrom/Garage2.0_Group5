using Garage2._0_Group5.Models.Entities;
using Garage2._0_Group5.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Validations
{
    public class CheckNameAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            const string errorMessage = "First and last name can not be same!";

            if (value is string input)
            {
                var model = validationContext.ObjectInstance as Name;

                if (model != null)
                {
                    if (input != model.FirstName)
                        return ValidationResult.Success;
                    else
                        return new ValidationResult(errorMessage);
                }
            }
            return new ValidationResult(errorMessage);
        }
    }
}
