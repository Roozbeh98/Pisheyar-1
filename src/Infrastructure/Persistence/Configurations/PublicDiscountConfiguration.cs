using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class PublicDiscountConfiguration : IEntityTypeConfiguration<PublicDiscount>
    {
        public void Configure(EntityTypeBuilder<PublicDiscount> entity)
        {
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.PublicDiscountGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TypeCode)
                .WithMany(p => p.PublicDiscount)
                .HasForeignKey(d => d.TypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicDiscount_Code");
        }
    }
}
