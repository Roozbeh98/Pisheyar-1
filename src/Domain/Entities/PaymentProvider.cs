using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class PaymentProvider
    {
        public PaymentProvider()
        {
            PaymentProviderSetting = new HashSet<PaymentProviderSetting>();
        }

        [Key]
        [Column("PaymentProviderID")]
        public int PaymentProviderId { get; set; }
        [Column("PaymentProviderGUID")]
        public Guid PaymentProviderGuid { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("PaymentProvider")]
        public virtual ICollection<PaymentProviderSetting> PaymentProviderSetting { get; set; }
    }
}
