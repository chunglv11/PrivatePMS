namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guest")]
    public partial class Guest
    {
        public int GuestId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string SurName { get; set; }

        [StringLength(200)]
        public string Photo { get; set; }

        public int? TypeGuestId { get; set; }

        [StringLength(50)]
        public string ZIPCode { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dob { get; set; }

        [StringLength(200)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string IdentityCart { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        [StringLength(100)]
        public string CreditCard { get; set; }

        [StringLength(50)]
        public string DoIssueCreditCard { get; set; }

        [StringLength(50)]
        public string CVC { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public DateTime? DateCreate { get; set; }

        [StringLength(50)]
        public string CreateBySource { get; set; }

        public double? TotalPaid { get; set; }

        public double? Discount { get; set; }
    }
}
