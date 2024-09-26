namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        public int CompanyId { get; set; }

        public int? HotelId { get; set; }

        public int? GroupGuestId { get; set; }

        public int? SourceId { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string CompanyCode { get; set; }

        [StringLength(100)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(200)]
        public string ContactUsName { get; set; }

        [StringLength(100)]
        public string ContactPhone { get; set; }

        [StringLength(200)]
        public string ContactEmail { get; set; }
    }
}
