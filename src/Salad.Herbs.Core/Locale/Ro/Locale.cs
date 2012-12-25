using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ro
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
            Language = "ro";

            _locales = new Hashtable
                           {
                               {"Feature", "Funcţionalitate"}, 
                               {"Scenario", "Scenariu"},
                               {"Given", "Dat"},
                               {"When", "Când"},
                               {"And", "și"},
                               {"Then", "Atunci"},
                               {"Examples", "Exemple"}
                           };
        }
    }
}
