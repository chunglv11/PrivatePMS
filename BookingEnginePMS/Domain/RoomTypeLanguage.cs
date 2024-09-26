namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomTypeLanguage")]
    public partial class RoomTypeLanguage
    {
        public int RoomTypeLanguageId { get; set; }

        public int? RoomTypeId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(200)]
        public string ExtrabedOption { get; set; }

        [StringLength(200)]
        public string DescriptionBed { get; set; }

        [StringLength(200)]
        public string DescriptionView { get; set; }

        [StringLength(500)]
        public string Note { get; set; }
    }
}
