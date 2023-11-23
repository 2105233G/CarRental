using CarRental.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Server.Configurations.Entities
{

    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make { Id = 1, Name = "BMW" },
                new Make { Id = 2, Name = "Toyota" }
            );
        }
    }
}
