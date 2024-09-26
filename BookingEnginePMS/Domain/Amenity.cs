namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Amenity")]
    public partial class Amenity
    {
        public int AmenityId { get; set; }

        public int? HotelId { get; set; }

        public int? Index { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}
