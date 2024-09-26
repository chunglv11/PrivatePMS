namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Policy")]
    public partial class Policy
    {
        public int PolicyId { get; set; }

        public int? HotelId { get; set; }

        public int? Index { get; set; }

        public bool? RequirePrice { get; set; }
    }
}
