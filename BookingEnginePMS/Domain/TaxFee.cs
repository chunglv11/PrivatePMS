namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxFee")]
    public partial class TaxFee
    {
        public int TaxFeeId { get; set; }

        public int? HotelId { get; set; }

        public float? Amount { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool? TypeTaxFee { get; set; }
    }
}
