namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gallary")]
    public partial class Gallary
    {
        public int GallaryId { get; set; }

        public int RoomTypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }
    }
}
