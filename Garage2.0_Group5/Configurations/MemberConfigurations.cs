using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Garage2._0_Group5.Configurations
{
    public class MemberConfigurations : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.OwnsOne(m => m.Name)
                .Property(n => n.FirstName)
                .HasColumnName("FirstName");

            builder.OwnsOne(m => m.Name)
                .Property(n => n.LastName)
                .HasColumnName("LastName");

            builder.HasMany(m => m.VehicleTypes)
                .WithMany(vt => vt.Members)
                .UsingEntity<Vehicle>(
                v => v.HasOne(v => v.VehicleType).WithMany(vt => vt.Vehicles),
                v => v.HasOne(v => v.Member).WithMany(vt => vt.Vehicles),
                v => v.HasKey(v => new { v.MemberId, v.VehicleTypeId }));
        }
    }
}
