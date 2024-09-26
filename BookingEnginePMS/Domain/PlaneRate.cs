namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaneRate")]
    public partial class PlaneRate
    {
        public int PlaneRateId { get; set; }

        public int? HotelId { get; set; }

        public double Price { get; set; }

        public bool Breakfast { get; set; }

        public bool Lunch { get; set; }

        public bool Dinner { get; set; }

        public bool? Deleted { get; set; }
    }
}
