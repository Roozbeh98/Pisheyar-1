using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    [Table("SMSProviderSettingNumber")]
    public partial class SmsProviderSettingNumber
    {
        [Key]
        [Column("SMSProviderSettingNumberID")]
        public int SmsProviderSettingNumberId { get; set; }
        [Column("SMSProviderSettingNumberGUID")]
        public Guid SmsProviderSettingNumberGuid { get; set; }
        [Column("SMSProviderSettingID")]
        public int SmsProviderSettingId { get; set; }
        [Required]
        [StringLength(128)]
        public string Value { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(SmsProviderSettingId))]
        [InverseProperty("SmsProviderSettingNumber")]
        public virtual SmsProviderSetting SmsProviderSetting { get; set; }
    }
}
