namespace BookingEnginePMS.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelLanguage")]
    public partial class HotelLanguage
    {
        public int HotelLanguageId { get; set; }

        public int? HotelId { get; set; }

        public int? LanguageId { get; set; }

        public string Terms { get; set; }

        public string InforAccount { get; set; }

        public string Note { get; set; }
    }
}
