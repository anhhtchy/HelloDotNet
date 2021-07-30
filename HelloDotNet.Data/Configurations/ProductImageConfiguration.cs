using System;
using HelloDotNet.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelloDotNet.Data.Configurations
{
    public class ProductImageConfiguration
        : IEntityTypeConfiguration<ProductImage>
    {
        public ProductImageConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseMySqlIdentityColumn();
            builder.Property(t => t.ImagePath).HasMaxLength(200)
                .IsRequired(true);
            builder.Property(t => t.Caption).HasMaxLength(200)
                .IsRequired(false);
            builder.HasOne(t => t.Product).WithMany(t => t.ProductImages)
                .HasForeignKey(t => t.ProductId);
        }
    }
}
