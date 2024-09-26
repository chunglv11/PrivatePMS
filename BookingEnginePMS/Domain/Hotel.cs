namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        public int HotelId { get; set; }

        public int? GroupHotelId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public string Logo { get; set; }

        [StringLength(200)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Hotline { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        [StringLength(100)]
        public string Facebook { get; set; }

        [StringLength(100)]
        public string Skyper { get; set; }

        [StringLength(100)]
        public string Google { get; set; }

        [StringLength(100)]
        public string Youtobe { get; set; }

        public int? Status { get; set; }

        public bool? HighLight { get; set; }

        public int? TypeSoftware { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? TypePaymentHotel { get; set; }

        public double? CommissionRate { get; set; }

        public DateTime? DayStartUse { get; set; }

        public double? TimeExtended { get; set; }
    }
}
