namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        public int RoomId { get; set; }

        public int HotelId { get; set; }

        public int RoomTypeId { get; set; }

        [Required]
        [StringLength(10)]
        public string RoomCode { get; set; }

        public int? Floor { get; set; }

        public int? Status { get; set; }

        public bool? Deleted { get; set; }
    }
}
