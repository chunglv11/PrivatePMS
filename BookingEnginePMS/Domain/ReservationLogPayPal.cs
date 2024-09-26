namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationLogPayPal")]
    public partial class ReservationLogPayPal
    {
        public int ReservationLogPayPalId { get; set; }

        public int? ReservationId { get; set; }

        public string LogContent { get; set; }

        public DateTime? DateLog { get; set; }
    }
}
