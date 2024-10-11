using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingEnginePMS.Models
{
    public class HotelLanguage
    {
        public int HotelLanguageId { get; set; }
        public int LanguageId { get; set; }
        public string Terms { get; set; }
        public string InforAccount { get; set; }
        public string Note { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public string Phone { get; set; }
        public string Hotline { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Skyper { get; set; }
        public string Google { get; set; }
        public string Youtube { get; set; }
        public string Website { get; set; }

    }
}