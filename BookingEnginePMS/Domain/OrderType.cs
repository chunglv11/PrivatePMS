namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderType")]
    public partial class OrderType
    {
        public int OrderTypeId { get; set; }

        [StringLength(100)]
        public string OrderTypeName { get; set; }
    }
}
