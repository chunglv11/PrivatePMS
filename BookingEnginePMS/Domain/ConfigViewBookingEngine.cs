namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigViewBookingEngine")]
    public partial class ConfigViewBookingEngine
    {
        public int ConfigViewBookingEngineId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(10)]
        public string Lang { get; set; }

        [StringLength(10)]
        public string Currency { get; set; }
    }
}
