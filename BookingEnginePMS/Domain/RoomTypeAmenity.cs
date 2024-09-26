namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomTypeAmenity")]
    public partial class RoomTypeAmenity
    {
        public int RoomTypeAmenityId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? AmenityId { get; set; }
    }
}
