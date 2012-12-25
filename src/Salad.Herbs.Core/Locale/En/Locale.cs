using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.En
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
            Language = "en";

            _locales = new Hashtable
                           {
                               {"Feature", "Feature"}, 
                               {"Scenario", "Scenario Outline"},
                               {"Scenario1", "Scenario"},
                               {"Given", "Given"},
                               {"When", "When"},
                               {"And", "And"},
                               {"Then", "Then"}
                           };
        }
    }
}
