namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaneRateLanguage")]
    public partial class PlaneRateLanguage
    {
        public int PlaneRateLanguageId { get; set; }

        public int? PlaneRateId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }
    }
}
