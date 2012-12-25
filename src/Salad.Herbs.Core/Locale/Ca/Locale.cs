using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ca
{
    public class Locale : ILocale
    {
        public string Language;

        private Hashtable _locales;

        public Hashtable GetLocales ()
        {
            return _locales;
        }

        public void Initialize ()
        {
            Language = "ca";

            _locales = new Hashtable
                           {
                               {"Feature", "Característica"}, 
                               {"Scenario", "Esquema de l'escenari"},
                               {"Scenario1", "escenari"},
                               {"Given", "Donat"}, 
                               {"When", "Quan"},
                               {"And", "I"},
                               {"Then", "Aleshores"}
                           };
        }
    }
}
