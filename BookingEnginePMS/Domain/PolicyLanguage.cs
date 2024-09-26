namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyLanguage")]
    public partial class PolicyLanguage
    {
        public int PolicyLanguageId { get; set; }

        public int? PolicyId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(100)]
        public string PolicyName { get; set; }

        public string Content { get; set; }
    }
}
