namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigPaymentMethodHotel")]
    public partial class ConfigPaymentMethodHotel
    {
        public int ConfigPaymentMethodHotelId { get; set; }

        public int? ConfigPaymentMethodId { get; set; }

        public int? HotelId { get; set; }

        public int? Index { get; set; }

        public bool? Active { get; set; }

        public bool? RequireCard { get; set; }

        public bool? ActiveInvoice { get; set; }
    }
}
