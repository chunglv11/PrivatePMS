namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Extrabed")]
    public partial class Extrabed
    {
        public int ExtrabedId { get; set; }

        public int? HotelId { get; set; }

        public double? Price { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
    }
}
