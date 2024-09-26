namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        public int UserLoginId { get; set; }

        public int? UserId { get; set; }

        [StringLength(500)]
        public string UserAgent { get; set; }

        [StringLength(200)]
        public string Ip { get; set; }

        public DateTime? LastestLogin { get; set; }
    }
}
