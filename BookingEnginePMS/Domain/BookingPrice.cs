namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingPrice")]
    public partial class BookingPrice
    {
        public int BookingPriceId { get; set; }

        public int? BookingId { get; set; }

        public DateTime? Date { get; set; }

        public double? Price { get; set; }

        public bool? Paid { get; set; }
    }
}
