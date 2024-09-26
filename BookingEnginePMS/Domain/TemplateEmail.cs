namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TemplateEmail")]
    public partial class TemplateEmail
    {
        public int TemplateEmailId { get; set; }

        public int? HotelId { get; set; }

        public int? TypeEmailId { get; set; }

        public string CC { get; set; }

        public string BCC { get; set; }

        [Required]
        [StringLength(500)]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
