namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoucherRoomType")]
    public partial class VoucherRoomType
    {
        public int VoucherRoomTypeId { get; set; }

        public int? VoucherId { get; set; }

        public int? RoomTypeId { get; set; }
    }
}
