namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceBooking")]
    public partial class InvoiceBooking
    {
        public int InvoiceBookingId { get; set; }

        public int? BookingId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public DateTime? CreateDate { get; set; }

        public string JsonData { get; set; }

        [StringLength(100)]
        public string UserCreate { get; set; }
    }
}
