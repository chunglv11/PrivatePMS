namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRole")]
    public partial class UserRole
    {
        public int UserRoleId { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }

        public bool? Access { get; set; }
    }
}
