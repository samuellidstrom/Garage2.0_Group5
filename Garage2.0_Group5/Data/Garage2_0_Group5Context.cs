using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Models.Entities;

namespace Garage2._0_Group5.Data
{
    public class Garage2_0_Group5Context : DbContext
    {
        public Garage2_0_Group5Context(DbContextOptions<Garage2_0_Group5Context> options)
            : base(options)
        {
        }

        public DbSet<ParkedVehicle> ParkedVehicle => Set<ParkedVehicle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkedVehicle>().HasData(
                new ParkedVehicle
                {
                    Id = 1,
                    VehicleType = VehicleType.Car,
                    RegistrationNumber = string.Empty,
                    Color = string.Empty,
                    VehicleBrand = VehicleBrand.Volvo,
                    VehicleModel = string.Empty,
                    NumberOfWheels = 4,
                    TimeAtCheckIn = DateTime.UtcNow,
                    TimeAtCheckOut = DateTime.UtcNow
                },

                new ParkedVehicle
                {
                    Id = 2,
                    VehicleType = VehicleType.Airplane,
                    RegistrationNumber = string.Empty,
                    Color = string.Empty,
                    VehicleBrand = VehicleBrand.SAS,
                    VehicleModel = string.Empty,
                    NumberOfWheels = 3,
                    TimeAtCheckIn = DateTime.UtcNow,
                    TimeAtCheckOut = DateTime.UtcNow
                },

                new ParkedVehicle
                {
                    Id = 3,
                    VehicleType = VehicleType.Bicycle,
                    RegistrationNumber = string.Empty,
                    Color = string.Empty,
                    VehicleBrand = VehicleBrand.Shimano,
                    VehicleModel = string.Empty,
                    NumberOfWheels = 2,
                    TimeAtCheckIn = DateTime.UtcNow,
                    TimeAtCheckOut = DateTime.UtcNow
                },

                new ParkedVehicle
                {
                    Id = 4,
                    VehicleType = VehicleType.Motorcycle,
                    RegistrationNumber = string.Empty,
                    Color = string.Empty,
                    VehicleBrand = VehicleBrand.Harley,
                    VehicleModel = string.Empty,
                    NumberOfWheels = 2,
                    TimeAtCheckIn = DateTime.UtcNow,
                    TimeAtCheckOut = DateTime.UtcNow
                },

                new ParkedVehicle
                {
                    Id = 5,
                    VehicleType = VehicleType.Boat,
                    RegistrationNumber = string.Empty,
                    Color = string.Empty,
                    VehicleBrand = VehicleBrand.Boston,
                    VehicleModel = string.Empty,
                    NumberOfWheels = 1,
                    TimeAtCheckIn = DateTime.UtcNow,
                    TimeAtCheckOut = DateTime.UtcNow
                }
                );
        }
    }
}
