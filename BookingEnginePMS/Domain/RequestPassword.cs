namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestPassword")]
    public partial class RequestPassword
    {
        public int RequestPasswordId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Token { get; set; }

        public DateTime? RequestDate { get; set; }
    }
}
