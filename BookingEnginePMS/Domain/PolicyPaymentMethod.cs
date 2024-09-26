namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolicyPaymentMethod")]
    public partial class PolicyPaymentMethod
    {
        public int PolicyPaymentMethodId { get; set; }

        public int? HotelId { get; set; }

        public int? LanguageId { get; set; }

        public int? ConfigPaymentMethodId { get; set; }

        public string Policy { get; set; }
    }
}
