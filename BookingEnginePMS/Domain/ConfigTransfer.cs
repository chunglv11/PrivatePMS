namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigTransfer")]
    public partial class ConfigTransfer
    {
        public int ConfigTransferId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(100)]
        public string Bank { get; set; }

        [StringLength(100)]
        public string AccountNumber { get; set; }

        [StringLength(100)]
        public string NameOnCard { get; set; }

        [StringLength(100)]
        public string Branch { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public bool? Status { get; set; }
    }
}
