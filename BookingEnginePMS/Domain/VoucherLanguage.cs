namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoucherLanguage")]
    public partial class VoucherLanguage
    {
        public int VoucherLanguageId { get; set; }

        public int? VoucherId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
