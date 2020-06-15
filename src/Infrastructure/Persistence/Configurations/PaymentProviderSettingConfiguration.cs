using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class PaymentProviderSettingConfiguration : IEntityTypeConfiguration<PaymentProviderSetting>
    {
        public void Configure(EntityTypeBuilder<PaymentProviderSetting> entity)
        {
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PaymentProviderSettingGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PaymentProvider)
                .WithMany(p => p.PaymentProviderSetting)
                .HasForeignKey(d => d.PaymentProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentProviderSetting_PaymentProvider");
        }
    }
}
