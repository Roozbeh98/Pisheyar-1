using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class PrivateDiscount
    {
        [Key]
        [Column("PrivateDiscountID")]
        public int PrivateDiscountId { get; set; }
        [Column("PrivateDiscountGUID")]
        public Guid PrivateDiscountGuid { get; set; }
        [Column("ContractorID")]
        public int ContractorId { get; set; }
        [Column("TypeCodeID")]
        public int TypeCodeId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public int Value { get; set; }
        public int MaximumUsesNumber { get; set; }
        public int NumberUsed { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey(nameof(ContractorId))]
        [InverseProperty("PrivateDiscount")]
        public virtual Contractor Contractor { get; set; }
        [ForeignKey(nameof(TypeCodeId))]
        [InverseProperty(nameof(Code.PrivateDiscount))]
        public virtual Code TypeCode { get; set; }
    }
}
