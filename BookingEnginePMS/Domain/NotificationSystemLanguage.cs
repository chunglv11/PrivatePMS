namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationSystemLanguage")]
    public partial class NotificationSystemLanguage
    {
        public int NotificationSystemLanguageId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
