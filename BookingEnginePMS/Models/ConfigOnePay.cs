using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace BookingEnginePMS.Models
{
    public class ConfigOnePay
    {
        public int ConfigOnePayId { get; set; }
        public string MerchantId { get; set; }
        public string AccessCode { get; set; }
        public string Hashcode { get; set; }
        public string WebSite { get; set; }
        public string Status { get; set; }
    }
}
