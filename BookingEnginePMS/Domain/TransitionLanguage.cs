namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransitionLanguage")]
    public partial class TransitionLanguage
    {
        public int TransitionLanguageId { get; set; }

        public int TransitionId { get; set; }

        public int? LanguageId { get; set; }

        public string Result { get; set; }
    }
}
