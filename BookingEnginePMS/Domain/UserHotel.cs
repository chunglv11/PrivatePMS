namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHotel")]
    public partial class UserHotel
    {
        public int UserHotelId { get; set; }

        public int? UserId { get; set; }

        public int? HotelId { get; set; }

        public bool? Access { get; set; }
    }
}
