namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Source")]
    public partial class Source
    {
        public int SourceId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string SourceName { get; set; }
    }
}
