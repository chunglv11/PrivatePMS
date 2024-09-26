namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeGuest")]
    public partial class TypeGuest
    {
        public int TypeGuestId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string TypeGuestName { get; set; }

        public double? MinAmount { get; set; }

        public double? Discount { get; set; }

        public int? Level { get; set; }
    }
}
