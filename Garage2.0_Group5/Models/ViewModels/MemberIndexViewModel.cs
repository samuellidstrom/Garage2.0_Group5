namespace Garage2._0_Group5.Models.ViewModels
{
#nullable disable
    public class MemberIndexViewModel
    {
        public int Id { get; set; }
        public string NameFullName { get; set; }

        public string Email { get; set; }
        public string PersonNumber { get; set; }

        //public IEnumerable<VehicleInfo> VehicleInfos { get; set; }
    }

    public record MemberIndexViewModel2(int Id, string FullName, string Email, string PersonNumber);

    //public class VehicleInfo
    //{
    //    public string LicenseNumber { get; set; }
    //    public DateTime TimeOfRegistration { get; set; }
    //}
}
