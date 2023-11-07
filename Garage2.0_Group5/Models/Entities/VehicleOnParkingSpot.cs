namespace Garage2._0_Group5.Models.Entities
{
    public class VehicleOnParkingSpot
    {
        public int Id { get; set; }
        public int ParkedVehicleId { get; set; }
        public int ParkingLotId { get; set; }
        public ParkedVehicle ParkedVehicle { get; set; }
        public ParkingLot ParkingLot { get; set; }

    }
}
