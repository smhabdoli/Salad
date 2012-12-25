using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Et
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
            Language = "et";

            _locales = new Hashtable
                           {
                               {"Feature", "Omadus"}, 
                               {"Scenario", "Raamstsenaarium"},
                               {"Scenario1", "Stsenaarium"},
                               {"Given", "Eeldades"},
                               {"When", "Kui"},
                               {"And", "Ja"},
                               {"Then", "Siis"},
                               {"Examples", "Juhtumid"}
                           };
        }
    }
}
