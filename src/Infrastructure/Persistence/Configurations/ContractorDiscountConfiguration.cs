using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class ContractorDiscountConfiguration : IEntityTypeConfiguration<ContractorDiscount>
    {
        public void Configure(EntityTypeBuilder<ContractorDiscount> entity)
        {
            entity.Property(e => e.ContractorDiscountGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.ContractorDiscount)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorDiscount_Contractor");

            entity.HasOne(d => d.PublicDiscount)
                .WithMany(p => p.ContractorDiscount)
                .HasForeignKey(d => d.PublicDiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorDiscount_PublicDiscount");
        }
    }
}
