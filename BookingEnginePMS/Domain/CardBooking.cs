namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CardBooking")]
    public partial class CardBooking
    {
        public int CardBookingId { get; set; }

        public int? BookingId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(200)]
        public string Code { get; set; }

        public int? ExpirationMonth { get; set; }

        public int? ExpirationYear { get; set; }
    }
}
