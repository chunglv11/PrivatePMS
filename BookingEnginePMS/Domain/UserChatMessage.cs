namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserChatMessage")]
    public partial class UserChatMessage
    {
        public int UserChatMessageId { get; set; }

        public int? UserChatId { get; set; }

        public string Content { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(20)]
        public string UserSend { get; set; }
    }
}
