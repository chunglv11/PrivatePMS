namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashDrawer")]
    public partial class CashDrawer
    {
        public int CashDrawerId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Active { get; set; }

        public int? TimesOpened { get; set; }

        public double? LastBalance { get; set; }

        public DateTime? LastOpen { get; set; }

        public DateTime? LastClose { get; set; }

        [StringLength(100)]
        public string LastOpenedBy { get; set; }

        public bool? Deleted { get; set; }
    }
}
