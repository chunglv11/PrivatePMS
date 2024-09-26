namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RenewalRegistration")]
    public partial class RenewalRegistration
    {
        public int RenewalRegistrationId { get; set; }

        public int? LanguageId { get; set; }

        [StringLength(500)]
        public string Template { get; set; }
    }
}
