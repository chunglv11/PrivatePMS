namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomTypePriceHour")]
    public partial class RoomTypePriceHour
    {
        public int RoomTypePriceHourId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? HourStart { get; set; }

        public double? PriceStart { get; set; }

        public int? HourNext1 { get; set; }

        public double? PriceNext1 { get; set; }

        public int? HourNext2 { get; set; }

        public double? PriceNext2 { get; set; }

        public int? HourNext3 { get; set; }

        public double? PriceNext3 { get; set; }
    }
}
