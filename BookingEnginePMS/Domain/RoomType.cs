namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomType")]
    public partial class RoomType
    {
        public int RoomTypeId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [StringLength(100)]
        public string RoomTypeName { get; set; }

        [StringLength(20)]
        public string RoomTypeCode { get; set; }

        public int? MaxPeople { get; set; }

        public int? Adult { get; set; }

        public int? Children { get; set; }

        public bool? HasExtrabed { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Size { get; set; }

        public int? Index { get; set; }

        public bool? Deleted { get; set; }
    }
}
