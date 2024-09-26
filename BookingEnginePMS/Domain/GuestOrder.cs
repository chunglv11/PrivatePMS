namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuestOrder")]
    public partial class GuestOrder
    {
        public int GuestOrderId { get; set; }

        public int? HotelId { get; set; }

        [StringLength(20)]
        public string GuestOrderCode { get; set; }

        public int? GuestId { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Paid { get; set; }

        [StringLength(50)]
        public string Cashier { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public bool? isMoved { get; set; }

        public DateTime? DatePaid { get; set; }
    }
}
