namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceCategory")]
    public partial class ServiceCategory
    {
        public int ServiceCategoryId { get; set; }

        public int HotelId { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public int? Index { get; set; }
    }
}
