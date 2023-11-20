namespace Garage2._0_Group5.Models.Entities
{
    #nullable disable
    public class Type
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }
        public int Wheels { get; set; }


        //Foreign key
        public int VehicleId { get; set; }

        //Nav property
        public Vehicle Vehicle { get; set; }
    }
}
