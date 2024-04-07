﻿using E_Shop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.DAL.EntitiesConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.HasMany(x=>x.Images)
                .WithOne(x=>x.Product)
                .HasForeignKey(x=>x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}