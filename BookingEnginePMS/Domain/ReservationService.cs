namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationService")]
    public partial class ReservationService
    {
        public int ReservationServiceId { get; set; }

        public int? ReservationId { get; set; }

        public int? ServiceId { get; set; }

        public int? Number { get; set; }

        public double? Price { get; set; }

        public bool? Paid { get; set; }

        public DateTime? DateCreate { get; set; }
    }
}
