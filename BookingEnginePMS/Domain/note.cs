namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("note")]
    public partial class note
    {
        public int noteId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string View { get; set; }

        [StringLength(100)]
        public string content { get; set; }
    }
}
