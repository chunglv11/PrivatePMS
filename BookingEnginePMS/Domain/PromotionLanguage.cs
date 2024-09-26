namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PromotionLanguage")]
    public partial class PromotionLanguage
    {
        public int PromotionLanguageId { get; set; }

        public int? PromotionId { get; set; }

        public int? LanguageId { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }
    }
}
