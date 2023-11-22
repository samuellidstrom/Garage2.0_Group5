using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Garage2._0_Group5.Validations
{
    public class CheckAgeAttribute : ValidationAttribute
    {
        public bool IsAgeValid(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            if (birthDate < today.AddYears(-18))
                return true;
            else
                return false;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string validationRegEx = @"^(?<date>\d{8})[-\s]?\d{4}$";
            string date = Regex.Match((string)value, validationRegEx).Groups["date"].Value;
            if (DateTime.TryParseExact(date, new[] { "yyyyMMdd" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
            {
                if (IsAgeValid(dt))
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Member must be 18 years old!");
            }
            return new ValidationResult("Person Number format must be YYYYMMDDNNNN");
        }
    }
}
