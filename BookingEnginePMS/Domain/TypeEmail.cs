namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeEmail")]
    public partial class TypeEmail
    {
        public int TypeEmailId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
    }
}
