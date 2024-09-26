namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CurrencyUsed")]
    public partial class CurrencyUsed
    {
        public int CurrencyUsedId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(20)]
        public string Key { get; set; }
    }
}
