namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupGuest")]
    public partial class GroupGuest
    {
        public int GroupGuestId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string GroupGuestName { get; set; }
    }
}
