namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigVTCPay")]
    public partial class ConfigVTCPay
    {
        public int ConfigVTCPayId { get; set; }

        [Required]
        [StringLength(100)]
        public string ReceiverAccount { get; set; }

        [Required]
        [StringLength(100)]
        public string WebSite { get; set; }

        [Required]
        [StringLength(100)]
        public string SecurityKey { get; set; }

        [Required]
        [StringLength(50)]
        public string WebsiteId { get; set; }

        public int? HotelId { get; set; }
    }
}
