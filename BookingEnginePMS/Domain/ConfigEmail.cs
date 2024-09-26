namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigEmail")]
    public partial class ConfigEmail
    {
        public int ConfigEmailId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string EmailReceive { get; set; }

        [StringLength(500)]
        public string SubjectOffline { get; set; }

        [StringLength(500)]
        public string SubjectOnline { get; set; }
    }
}
