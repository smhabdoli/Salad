using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Fa
{
    public class Locale : ILocale
    {
        public string Language;

        private Hashtable _locales ;

        public Hashtable GetLocales()
        {
            return _locales;
        }

        public void Initialize()
        {
            Language = "fa";

            _locales = new Hashtable
                           {
                               {"Feature", "خصیصه"}, 
                               {"Scenario", "سناریوی اجمالی"},
                               {"Scenario1", "سناریو"},
                               {"Given", "مفروض"},
                               {"When", "وقتی که"},
                               {"And", "و"},
                               {"Then", "آنگاه"},
                               {"Examples", "نمونه ها"}
                           };
        }
    }
}
