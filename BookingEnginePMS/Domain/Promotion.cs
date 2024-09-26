namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promotion")]
    public partial class Promotion
    {
        public int PromotionId { get; set; }

        public int? HotelId { get; set; }

        public int PlaneRateId { get; set; }

        public int TypePromotion { get; set; }

        [Required]
        [StringLength(200)]
        public string PromotionName { get; set; }

        public int DayInHouse { get; set; }

        public int EarlyDay { get; set; }

        public int? NightForFreeNight { get; set; }

        public double Deposit { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }

        public int PolicyId { get; set; }

        public double AmountRate { get; set; }

        public bool Status { get; set; }

        public bool? Deleted { get; set; }
    }
}
