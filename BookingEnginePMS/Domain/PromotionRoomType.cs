namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromotionRoomType")]
    public partial class PromotionRoomType
    {
        public int PromotionRoomTypeId { get; set; }

        public int? PromotionId { get; set; }

        public int? RoomTypeId { get; set; }
    }
}
