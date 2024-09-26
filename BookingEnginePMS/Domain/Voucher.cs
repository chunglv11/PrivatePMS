namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voucher")]
    public partial class Voucher
    {
        public int VoucherId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(20)]
        public string VoucherCode { get; set; }

        [StringLength(200)]
        public string VoucherName { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public bool? DiscountForService { get; set; }

        public float? AmountForService { get; set; }

        public bool? DiscountForRoom { get; set; }

        public float? AmountForRoom { get; set; }

        public int? Number { get; set; }
    }
}
