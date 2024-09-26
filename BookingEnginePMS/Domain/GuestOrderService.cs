namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuestOrderService")]
    public partial class GuestOrderService
    {
        public int GuestOrderServiceId { get; set; }

        public int? GuestOrderId { get; set; }

        public int? ServiceId { get; set; }

        public int? Number { get; set; }

        public double? Price { get; set; }
    }
}
