namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservationSource")]
    public partial class ReservationSource
    {
        public int ReservationSourceId { get; set; }

        [Required]
        [StringLength(100)]
        public string SourceName { get; set; }

        public bool? Status { get; set; }

        public int? TaxFeeId { get; set; }
    }
}
