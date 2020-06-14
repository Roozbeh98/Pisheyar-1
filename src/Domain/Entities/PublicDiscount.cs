using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class PublicDiscount
    {
        public PublicDiscount()
        {
            ContractorDiscount = new HashSet<ContractorDiscount>();
        }

        [Key]
        [Column("PublicDiscountID")]
        public int PublicDiscountId { get; set; }
        [Column("PublicDiscountGUID")]
        public Guid PublicDiscountGuid { get; set; }
        [Column("TypeCodeID")]
        public int TypeCodeId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey(nameof(TypeCodeId))]
        [InverseProperty(nameof(Code.PublicDiscount))]
        public virtual Code TypeCode { get; set; }
        [InverseProperty("PublicDiscount")]
        public virtual ICollection<ContractorDiscount> ContractorDiscount { get; set; }
    }
}
