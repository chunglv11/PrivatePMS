namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigPaymentMethod")]
    public partial class ConfigPaymentMethod
    {
        public int ConfigPaymentMethodId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
