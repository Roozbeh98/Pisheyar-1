using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class Complaint
    {
        [Key]
        [Column("ComplaintID")]
        public int ComplaintId { get; set; }
        [Column("ComplaintGUID")]
        public Guid ComplaintGuid { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(512)]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Complaint")]
        public virtual User User { get; set; }
    }
}
