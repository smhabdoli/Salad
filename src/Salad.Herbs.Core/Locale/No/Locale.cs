using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.No
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
            Language = "no";

            _locales = new Hashtable
                           {
                               {"Feature", "Egenskap"}, 
                               {"Scenario", "Scenario"},
                               {"Given", "Gitt"},
                               {"When", "Når"},
                               {"And", "Og"},
                               {"Then", "Så"},
                               {"Examples", "Eksempler"}
                           };
        }
    }
}
