using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ar
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
            Language = "ar";

            _locales = new Hashtable
                           {
                               {"Feature", "خاصية"}, 
                               {"Scenario", "سيناريو مخطط"}, 
                               {"Given", "في الآلة"}, 
                               {"When", "متى"},
                               {"And", "و"},
                               {"Then", "على"}
                           };
        }
    }
}
