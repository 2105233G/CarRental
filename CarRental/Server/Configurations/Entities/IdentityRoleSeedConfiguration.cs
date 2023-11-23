namespace CarRental.Server.Configurations.Entities
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace CarRentalManagement.Server.Configurations.Entities
    {
        public class IdentityRoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole<string>>
        {
            public void Configure(EntityTypeBuilder<IdentityRole<string>> builder)
            {
                builder.HasData(
                    new IdentityRole<string>
                    {
                        Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole<string>
                    {
                        Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );
            }
        }
    }

}
