using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Fi
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
            Language = "fi";

            _locales = new Hashtable
                           {
                               {"Feature", "Ominaisuus"}, 
                               {"Scenario", "Tapausaihio"},
                               {"Scenario1", "Tapaus"},
                               {"Given", "Oletetaan"},
                               {"When", "Kun"},
                               {"And", "Ja"},
                               {"Then", "Niin"},
                               {"Examples", "Tapaukset"}
                           };
        }
    }
}
