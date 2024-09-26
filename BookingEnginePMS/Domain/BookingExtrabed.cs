namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingExtrabed")]
    public partial class BookingExtrabed
    {
        public int BookingExtrabedId { get; set; }

        public int? BookingId { get; set; }

        public int? ExtrabedId { get; set; }

        public int? Number { get; set; }

        public double? Price { get; set; }

        public bool? Paid { get; set; }

        public DateTime? DatePaid { get; set; }

        public DateTime? DateCreate { get; set; }
    }
}
