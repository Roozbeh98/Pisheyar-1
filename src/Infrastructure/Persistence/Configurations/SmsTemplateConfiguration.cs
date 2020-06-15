using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Infrastructure.Persistence.Configurations
{
    public class SmsTemplateConfiguration : IEntityTypeConfiguration<SmsTemplate>
    {
        public void Configure(EntityTypeBuilder<SmsTemplate> entity)
        {
            entity.HasIndex(e => e.SmsProviderSettingId)
                    .HasName("IX_Tbl_SMSTemplate_ST_SSID");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SmsTemplateGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.SmsProviderSetting)
                .WithMany(p => p.SmsTemplate)
                .HasForeignKey(d => d.SmsProviderSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSTemplate_SMSProviderSetting");
        }
    }
}
