namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationDepositBooking")]
    public partial class ReservationDepositBooking
    {
        public int ReservationDepositBookingId { get; set; }

        public int? ReservationId { get; set; }

        public int? BookingId { get; set; }

        public double? Paid { get; set; }
    }
}
