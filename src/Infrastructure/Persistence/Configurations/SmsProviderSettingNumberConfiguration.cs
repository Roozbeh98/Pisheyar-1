using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class SmsProviderSettingNumberConfiguration : IEntityTypeConfiguration<SmsProviderSettingNumber>
    {
        public void Configure(EntityTypeBuilder<SmsProviderSettingNumber> entity)
        {
            entity.HasIndex(e => e.SmsProviderSettingId)
                    .HasName("IX_Tbl_SMSProviderNumber_SPN_SPCID");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SmsProviderSettingNumberGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.SmsProviderSetting)
                .WithMany(p => p.SmsProviderSettingNumber)
                .HasForeignKey(d => d.SmsProviderSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSProviderSettingNumber_SMSProviderSetting");
        }
    }
}
