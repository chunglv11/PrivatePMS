namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailAttachment")]
    public partial class EmailAttachment
    {
        public int EmailAttachmentId { get; set; }

        public int? TemplateEmailId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }
    }
}
