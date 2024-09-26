namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        public int LanguageId { get; set; }

        [Required]
        [StringLength(5)]
        public string Key { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Ensign { get; set; }

        public int? Index { get; set; }

        public bool? Active { get; set; }
    }
}
