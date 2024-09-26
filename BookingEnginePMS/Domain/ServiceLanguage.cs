namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceLanguage")]
    public partial class ServiceLanguage
    {
        public int ServiceLanguageId { get; set; }

        public int? ServiceId { get; set; }

        public int? LanguageId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string Policy { get; set; }
    }
}
