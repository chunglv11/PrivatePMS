namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashHistory")]
    public partial class CashHistory
    {
        public int CashHistoryId { get; set; }

        public int? HotelId { get; set; }

        public int? CashDrawerId { get; set; }

        public DateTime? DateOpened { get; set; }

        public double? StartBalance { get; set; }

        public double? DrawerBalance { get; set; }

        public double? CashDrop { get; set; }

        [StringLength(500)]
        public string NoteOpen { get; set; }

        [StringLength(500)]
        public string NoteClose { get; set; }

        [StringLength(100)]
        public string UserSession { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateClosed { get; set; }
    }
}
