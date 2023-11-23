using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Models.Entities;
using System.Reflection.Emit;
using Garage2._0_Group5.Configurations;

namespace Garage2._0_Group5.Data
{
    public class Garage2_0_Group5Context : DbContext
    {
        public Garage2_0_Group5Context(DbContextOptions<Garage2_0_Group5Context> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Member> Member { get; set; } = default!;
        //public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MemberConfigurations());

            //modelBuilder.Entity<Member>().OwnsOne(m => m.Name);



            //modelBuilder.Entity<Vehicle>().HasKey(v => new { v.MemberId, v.VehicleTypeId });
        }
    }
}
