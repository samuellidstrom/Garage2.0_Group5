using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    public class ParkedVehicle
	{
		public int Id { get; set; }

        [DisplayName("Vehicle Type")]
        public VehicleType VehicleType { get; set; }

        [DisplayName("Registration Number")]
        [RegularExpression(@"^[a-zA-Z]{3}\d{3}$", ErrorMessage = "Registration format must be ABC123")]
        [StringLength(6, MinimumLength = 6)]
        public string RegistrationNumber { get; set; } = string.Empty;

        [DisplayName("Color")]
        [StringLength(15, MinimumLength = 3)]
		public string? Color { get; set; }

        [DisplayName("Vehicle Brand")]
        [StringLength(15, MinimumLength = 3)]
        public VehicleBrand VehicleBrand { get; set; }


        [DisplayName("Vehicle Model")]
        [StringLength(15, MinimumLength = 3)]
        public string? VehicleModel { get; set; }

        [DisplayName("Number of Wheels")]
        [Range(1, 10, ErrorMessage = "The number of wheels must be non-negative.")]
        public int NumberOfWheels { get; set; }


		[DataType(DataType.Time)]
		[Display(Name ="Check In Time")]
		public DateTime TimeAtCheckIn { get; set; } // Property for check-in timestamp

        [Display(Name = "Check Out Time")]
        public DateTime? TimeAtCheckOut { get; set; } // Property for check-out timestamp

		public ParkedVehicle()
		{
			TimeAtCheckIn = DateTime.UtcNow;
		}

		// Method to calculate elapsed time between check-in and check-out
		public TimeSpan CalculateElapsedTime()
		{
			if (TimeAtCheckOut.HasValue)
			{
				return TimeAtCheckOut.Value - TimeAtCheckIn;
			}
			else
			{
				throw new InvalidOperationException("Vehicle has not been checked out.");
			}
		}
	}
}

