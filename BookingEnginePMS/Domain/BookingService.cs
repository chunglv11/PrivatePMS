namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookingService")]
    public partial class BookingService
    {
        public int BookingServiceId { get; set; }

        public int? BookingId { get; set; }

        public int? ServiceId { get; set; }

        public int? Number { get; set; }

        public double? Price { get; set; }

        public bool? Paid { get; set; }

        public DateTime? DatePaid { get; set; }

        public DateTime? DateCreate { get; set; }
    }
}
