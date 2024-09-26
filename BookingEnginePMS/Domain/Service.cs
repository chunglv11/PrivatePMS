namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        public int ServiceId { get; set; }

        public int HotelId { get; set; }

        public int ServiceCategoryId { get; set; }

        [Required]
        [StringLength(10)]
        public string ServiceCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Photo { get; set; }

        public int? Index { get; set; }

        public bool? BuyOnline { get; set; }

        public float? Price { get; set; }

        public bool? Deleted { get; set; }
    }
}
