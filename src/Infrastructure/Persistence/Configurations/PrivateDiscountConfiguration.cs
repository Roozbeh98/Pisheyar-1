using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class PrivateDiscountConfiguration : IEntityTypeConfiguration<PrivateDiscount>
    {
        public void Configure(EntityTypeBuilder<PrivateDiscount> entity)
        {
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.PrivateDiscountGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.PrivateDiscount)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrivateDiscount_Contractor");

            entity.HasOne(d => d.TypeCode)
                .WithMany(p => p.PrivateDiscount)
                .HasForeignKey(d => d.TypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrivateDiscount_Code");
        }
    }
}
