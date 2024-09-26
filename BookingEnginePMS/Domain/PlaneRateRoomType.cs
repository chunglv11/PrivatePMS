namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaneRateRoomType")]
    public partial class PlaneRateRoomType
    {
        public int PlaneRateRoomTypeId { get; set; }

        public int? PlaneRateId { get; set; }

        public int? RoomTypeId { get; set; }
    }
}
