using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Lv
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
            Language = "lv";

            _locales = new Hashtable
                           {
                               {"Feature", "Funkcionalitāte"}, 
                               {"Scenario", "Scenārijs pēc parauga"},
                               {"Scenario1", "Scenārijs"},
                               {"Given", "Kad"},
                               {"When", "Ja"},
                               {"And", "Un"},
                               {"Then", "Tad"},
                               {"Examples", "Paraugs"}
                           };
        }
    }
}
