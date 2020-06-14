using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    public partial class Setting
    {
        [Key]
        [Column("SettingID")]
        public int SettingId { get; set; }
        [Column("SettingGUID")]
        public Guid SettingGuid { get; set; }
        public int UserInitialCredit { get; set; }
        public int OrderRequestPrice { get; set; }
    }
}
