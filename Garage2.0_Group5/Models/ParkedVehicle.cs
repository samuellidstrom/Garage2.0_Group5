namespace Garage2._0_Group5.Models
{
	public class ParkedVehicle
	{
		public string Id { get; set; }
		public string Type { get; set; } = string.Empty;
		public string Color { get; set; }
		public string Brand { get; set; }
		public int NumberOfWheels { get; set; }
		public DateTime TimeAtCheckIn { get; set; }

		//public List<Vehicle> Vehicles { get; set; }
	}
}
