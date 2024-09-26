namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigCurrency")]
    public partial class ConfigCurrency
    {
        public int ConfigCurrencyId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        public double? Result { get; set; }

        public bool? AutoCalculator { get; set; }
    }
}
