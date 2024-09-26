namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigPayPal")]
    public partial class ConfigPayPal
    {
        public int ConfigPayPalId { get; set; }

        public int HotelId { get; set; }

        [StringLength(100)]
        public string MerchantId { get; set; }

        public bool? EmailConfirm { get; set; }

        public string LogCallAPI { get; set; }
    }
}
