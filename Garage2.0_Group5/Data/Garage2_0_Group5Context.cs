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

        public DbSet<Member> Member { get; set; } = default!;
        //public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Member>().OwnsOne(m => m.Name);

            modelBuilder.Entity<Member>()
                .OwnsOne(m => m.Name)
                .Property(n => n.FirstName)
                .HasColumnName("FirstName");

            modelBuilder.Entity<Member>()
                .OwnsOne(m => m.Name)
                .Property(n => n.LastName)
                .HasColumnName("LastName");

            modelBuilder.Entity<Member>()
                .HasMany(m => m.VehicleTypes)
                .WithMany(vt => vt.Members)
                .UsingEntity<Vehicle>(
                v => v.HasOne(v => v.VehicleType).WithMany(vt => vt.Vehicles),
                v => v.HasOne(v => v.Member).WithMany(vt => vt.Vehicles),
                v => v.HasKey(v => new { v.MemberId, v.VehicleTypeId }));

            //modelBuilder.Entity<Vehicle>().HasKey(v => new { v.MemberId, v.VehicleTypeId });
        }
    }
}
