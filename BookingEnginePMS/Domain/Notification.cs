namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        public int NotificationId { get; set; }

        public int? HotelId { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string UserCreate { get; set; }
    }
}
