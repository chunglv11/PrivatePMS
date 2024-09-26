namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigOnePay")]
    public partial class ConfigOnePay
    {
        public int ConfigOnePayId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [StringLength(100)]
        public string MerchantId { get; set; }

        [Required]
        [StringLength(100)]
        public string AccessCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Hashcode { get; set; }

        [Required]
        [StringLength(100)]
        public string WebSite { get; set; }

        public bool? Status { get; set; }
    }
}
