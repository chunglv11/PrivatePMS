namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationDebt")]
    public partial class ReservationDebt
    {
        public int ReservationDebtId { get; set; }

        public int? ReservationId { get; set; }

        public int? BookingId { get; set; }

        public double? TotalAmount { get; set; }

        public double? Paid { get; set; }
    }
}
