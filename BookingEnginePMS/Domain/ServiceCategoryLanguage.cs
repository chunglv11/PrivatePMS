namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceCategoryLanguage")]
    public partial class ServiceCategoryLanguage
    {
        public int ServiceCategoryLanguageId { get; set; }

        public int? LanguageId { get; set; }

        public int? ServiceCategoryId { get; set; }

        [StringLength(100)]
        public string ServiceCategoryName { get; set; }
    }
}
