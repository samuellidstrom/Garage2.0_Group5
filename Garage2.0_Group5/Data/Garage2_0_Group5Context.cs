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
        public Garage2_0_Group5Context (DbContextOptions<Garage2_0_Group5Context> options)
            : base(options)
        {
        }

        public DbSet<ParkedVehicle> ParkedVehicle => Set<ParkedVehicle>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ParkedVehicle>().HasData(
            //    new ParkedVehicle { Id = 1, VehicleType = "Car", VehicleBrand = "Toyota" },
            //    new ParkedVehicle { Id = 2, VehicleType = "Airplane", VehicleBrand = "SAS" },
            //    new ParkedVehicle { Id = 3, VehicleType = "Bike", VehicleBrand = "Shimano" },
            //    new ParkedVehicle { Id = 4, VehicleType = "Motorcycle", VehicleBrand = "Harley Davidson" },
            //    new ParkedVehicle { Id = 5, VehicleType = "Boat", VehicleBrand = "Boston whaler" }
            //    );
        }
    }
}
