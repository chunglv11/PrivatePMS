namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoucherService")]
    public partial class VoucherService
    {
        public int VoucherServiceId { get; set; }

        public int? VoucherId { get; set; }

        public int? ServiceId { get; set; }
    }
}
