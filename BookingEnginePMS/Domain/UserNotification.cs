namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserNotification")]
    public partial class UserNotification
    {
        public int UserNotificationId { get; set; }

        public int? UserId { get; set; }

        public int? NotificationId { get; set; }

        public bool? Status { get; set; }

        public bool? Access { get; set; }
    }
}
