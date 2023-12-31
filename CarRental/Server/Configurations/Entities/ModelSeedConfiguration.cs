﻿using CarRental.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Server.Configurations.Entities
{

    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model { Id = 1, Name = "3 Series" },
                new Model { Id = 2, Name = "X5" },
                new Model { Id = 3, Name = "Prius" },
                new Model { Id = 4, Name = "Rav4" }
            );
        }
    }
}
