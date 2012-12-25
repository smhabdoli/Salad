using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.De
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
            Language = "de";

            _locales = new Hashtable
                           {
                               {"Feature", "Funktionalität"}, 
                               {"Scenario", "Szenariogrundriss"},
                               {"Scenario1", "Szenario"},
                               {"Given", "Angenommen"},
                               {"Given1", "Gegeben sei"},
                               {"When", "Wenn"},
                               {"And", "Und"},
                               {"Then", "Dann"}
                           };
        }
    }
}
