using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    [Table("SMSProvider")]
    public partial class SmsProvider
    {
        public SmsProvider()
        {
            SmsProviderSetting = new HashSet<SmsProviderSetting>();
        }

        [Key]
        [Column("SMSProviderID")]
        public int SmsProviderId { get; set; }
        [Column("SMSProviderGUID")]
        public Guid SmsProviderGuid { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("SmsProvider")]
        public virtual ICollection<SmsProviderSetting> SmsProviderSetting { get; set; }
    }
}
