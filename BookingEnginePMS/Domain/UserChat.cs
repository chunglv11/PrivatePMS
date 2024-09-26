namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserChat")]
    public partial class UserChat
    {
        public int UserChatId { get; set; }

        public int? HotelId { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstUser { get; set; }

        [Required]
        [StringLength(20)]
        public string SecondUser { get; set; }
    }
}
