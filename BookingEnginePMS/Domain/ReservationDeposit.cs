namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationDeposit")]
    public partial class ReservationDeposit
    {
        public int ReservationDepositId { get; set; }

        public int? ReservationId { get; set; }

        public double? Deposit { get; set; }
    }
}
