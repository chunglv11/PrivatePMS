namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Currency")]
    public partial class Currency
    {
        [Key]
        [StringLength(50)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string Key { get; set; }
    }
}
