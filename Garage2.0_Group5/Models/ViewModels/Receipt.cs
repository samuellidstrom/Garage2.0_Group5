namespace Garage2._0_Group5.Models.ViewModels
{
    public class Receipt
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public TimeSpan TotalParkedTime { get; set; }
        public double ParkPrice { get; set; }
    }
}
