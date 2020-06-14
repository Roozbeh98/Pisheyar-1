using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class Suggestion
    {
        [Key]
        [Column("SuggestionID")]
        public int SuggestionId { get; set; }
        [Column("SuggestionGUID")]
        public Guid SuggestionGuid { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(512)]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Suggestion")]
        public virtual User User { get; set; }
    }
}
