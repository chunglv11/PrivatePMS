namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        public string Photo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string Token { get; set; }

        public bool? MasterRole { get; set; }
    }
}
