namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicePriceSchedule")]
    public partial class ServicePriceSchedule
    {
        public int ServicePriceScheduleId { get; set; }

        public DateTime? Date { get; set; }

        public float? Price { get; set; }
    }
}
