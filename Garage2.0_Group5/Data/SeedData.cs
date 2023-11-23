using Bogus;
using Bogus.Extensions.Sweden;
using Garage2._0_Group5.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using VehicleType = Garage2._0_Group5.Models.Entities.VehicleType;

namespace Garage2._0_Group5.Data
{
    public class SeedData
    {
        private static Faker faker = null!;

        public static async Task InitAsync(Garage2_0_Group5Context db)
        {
            if (await db.Member.AnyAsync()) return;

            faker = new Faker("sv");

            var members = GenerateMembers(10);
            await db.AddRangeAsync(members);

            var vehicleTypes = GenerateTypes(10);
            await db.AddRangeAsync(vehicleTypes);

            var vehicles = GenerateVehicles(vehicleTypes, members);
            await db.AddRangeAsync(vehicles);

            await db.SaveChangesAsync();

        }

        private static IEnumerable<Member> GenerateMembers(int numberOfMembers)
        {
            var members = new List<Member>();

            for (int i = 0; i < numberOfMembers; i++)
            {
                var fname = faker.Name.FirstName();
                var lname = faker.Name.LastName();
                var email = faker.Internet.Email(fname, lname, "lexicon.se");
                var personNumber = faker.Person.Personnummer();

                var member = new Member(new Name(fname, lname), email, personNumber)
                {
                    //FirstName = fname,
                    //LastName = lname,
                    //Email = email,
                };

                members.Add(member);
            }
            return members;
        }

        private static IEnumerable<VehicleType> GenerateTypes(int numberOfTypes)
        {

            var types = new List<VehicleType>();

            for (int i = 0; i < numberOfTypes; i++)
            {
                var typeOfVehicle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(faker.Vehicle.Manufacturer());
                var vehicleType = new VehicleType { TypeOfVehicle = typeOfVehicle };

                types.Add(vehicleType);
            }
            return types;
        }

        private static IEnumerable<Vehicle> GenerateVehicles(IEnumerable<VehicleType> vehicleTypes, IEnumerable<Member> members)
        {
            var rnd = new Random();
            var vehicles = new List<Vehicle>();

            foreach (var member in members)
            {
                foreach (var vehicletype in vehicleTypes)
                {
                    if (rnd.Next(0, 5) == 0)
                    {
                        var vehicle = new Vehicle
                        {
                            VehicleType = vehicletype,
                            Member = member,
                        };
                        vehicles.Add(vehicle);
                    }
                }
            }
            return vehicles;
        }
    }
}
