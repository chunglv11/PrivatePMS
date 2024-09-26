namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transition")]
    public partial class Transition
    {
        public int TransitionId { get; set; }

        public string Key { get; set; }

        public int? ScreenId { get; set; }
    }
}
