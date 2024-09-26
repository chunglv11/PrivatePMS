namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationEmailSent")]
    public partial class ReservationEmailSent
    {
        public int ReservationEmailSentId { get; set; }

        public int? ReservationId { get; set; }

        [StringLength(500)]
        public string Subject { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public string Content { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        public bool? Status { get; set; }
    }
}
