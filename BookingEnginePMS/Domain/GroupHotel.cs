namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupHotel")]
    public partial class GroupHotel
    {
        public int GroupHotelId { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(100)]
        public string GroupHotelName { get; set; }
    }
}
