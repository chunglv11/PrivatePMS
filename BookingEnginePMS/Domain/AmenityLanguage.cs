namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AmenityLanguage")]
    public partial class AmenityLanguage
    {
        public int AmenityLanguageId { get; set; }

        public int? AmenityId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(100)]
        public string AmenityName { get; set; }
    }
}
