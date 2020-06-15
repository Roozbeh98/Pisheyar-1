using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    [Table("SMSProviderSetting")]
    public partial class SmsProviderSetting
    {
        public SmsProviderSetting()
        {
            SmsProviderSettingNumber = new HashSet<SmsProviderSettingNumber>();
            SmsTemplate = new HashSet<SmsTemplate>();
        }

        [Key]
        [Column("SMSProviderSettingID")]
        public int SmsProviderSettingId { get; set; }
        [Column("SMSProviderSettingGUID")]
        public Guid SmsProviderSettingGuid { get; set; }
        [Column("SMSProviderID")]
        public int SmsProviderId { get; set; }
        [Required]
        [StringLength(128)]
        public string Username { get; set; }
        [Required]
        [StringLength(128)]
        public string Password { get; set; }
        [Required]
        [Column("APIKey")]
        [StringLength(128)]
        public string Apikey { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(SmsProviderId))]
        [InverseProperty("SmsProviderSetting")]
        public virtual SmsProvider SmsProvider { get; set; }
        [InverseProperty("SmsProviderSetting")]
        public virtual ICollection<SmsProviderSettingNumber> SmsProviderSettingNumber { get; set; }
        [InverseProperty("SmsProviderSetting")]
        public virtual ICollection<SmsTemplate> SmsTemplate { get; set; }
    }
}
