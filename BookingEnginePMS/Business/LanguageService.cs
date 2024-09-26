using BookingEnginePMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingEnginePMS.Business
{
    public class LanguageService
    {
        public Language GetByKey(string key)
        {
            using (var context = new MyContext())
            {
                return context.Languages.FirstOrDefault(x => x.Key.Equals(key));
            }
        }
    }
}