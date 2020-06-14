using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class ContractorDiscount
    {
        [Key]
        [Column("ContractorDiscountID")]
        public int ContractorDiscountId { get; set; }
        [Column("ContractorDiscountGUID")]
        public Guid ContractorDiscountGuid { get; set; }
        [Column("ContractorID")]
        public int ContractorId { get; set; }
        [Column("PublicDiscountID")]
        public int PublicDiscountId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey(nameof(ContractorId))]
        [InverseProperty("ContractorDiscount")]
        public virtual Contractor Contractor { get; set; }
        [ForeignKey(nameof(PublicDiscountId))]
        [InverseProperty("ContractorDiscount")]
        public virtual PublicDiscount PublicDiscount { get; set; }
    }
}
