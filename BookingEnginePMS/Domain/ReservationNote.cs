namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationNote")]
    public partial class ReservationNote
    {
        public int ReservationNoteId { get; set; }

        public int? ReservationId { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }
    }
}
