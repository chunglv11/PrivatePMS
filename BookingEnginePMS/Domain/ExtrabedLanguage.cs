namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtrabedLanguage")]
    public partial class ExtrabedLanguage
    {
        public int ExtrabedLanguageId { get; set; }

        public int? ExtrabedId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(100)]
        public string ExtrabedName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
