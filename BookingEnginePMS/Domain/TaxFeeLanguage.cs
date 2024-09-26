namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxFeeLanguage")]
    public partial class TaxFeeLanguage
    {
        public int TaxFeeLanguageId { get; set; }

        public int? TaxFeeId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(100)]
        public string TaxFeeName { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}
