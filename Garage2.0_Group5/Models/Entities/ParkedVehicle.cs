using System.ComponentModel.DataAnnotations;

namespace Garage2._0_Group5.Models.Entities
{
    public class ParkedVehicle
	{
		public int Id { get; set; }
		[StringLength(15)]
		public VehicleType VehicleType { get; set; }
		[StringLength(15)]
		public string RegistrationNumber { get; set; } = string.Empty;
		[StringLength(15)]
		public string? Color { get; set; }
		public VehicleBrand VehicleBrand { get; set; }
		[StringLength(15)]
		public string? VehicleModel { get; set; }
		public int NumberOfWheels { get; set; }
		[DataType(DataType.Time)]
		[Display(Name ="Check In Time")]
		public DateTime TimeAtCheckIn { get; } // Read-only property for check-in timestamp
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

