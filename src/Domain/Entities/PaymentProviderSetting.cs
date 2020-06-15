using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class PaymentProviderSetting
    {
        public PaymentProviderSetting()
        {
            Payment = new HashSet<Payment>();
        }

        [Key]
        [Column("PaymentProviderSettingID")]
        public int PaymentProviderSettingId { get; set; }
        [Column("PaymentProviderSettingGUID")]
        public Guid PaymentProviderSettingGuid { get; set; }
        [Column("PaymentProviderID")]
        public int PaymentProviderId { get; set; }
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

        [ForeignKey(nameof(PaymentProviderId))]
        [InverseProperty("PaymentProviderSetting")]
        public virtual PaymentProvider PaymentProvider { get; set; }
        [InverseProperty("PaymentProviderSetting")]
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
