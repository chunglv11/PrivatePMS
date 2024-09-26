namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RateAvailability")]
    public partial class RateAvailability
    {
        public int RateAvailabilityId { get; set; }

        public int RoomTypeId { get; set; }

        public double? Price { get; set; }

        public int? Number { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
