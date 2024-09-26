namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomTypeExtrabed")]
    public partial class RoomTypeExtrabed
    {
        public int RoomTypeExtrabedId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? ExtrabedId { get; set; }
    }
}
