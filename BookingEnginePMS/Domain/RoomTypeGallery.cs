namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomTypeGallery")]
    public partial class RoomTypeGallery
    {
        public int RoomTypeGalleryId { get; set; }

        public int RoomTypeId { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
    }
}
