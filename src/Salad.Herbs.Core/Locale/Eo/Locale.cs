using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Eo
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
            Language = "eo";

            _locales = new Hashtable
                           {
                               {"Feature", "Trajto"}, 
                               {"Scenario", "Konturo de la scenaro"},
                               {"Scenario1", "scenaro"},
                               {"Given", "Donitaĵo"},
                               {"When", "Se"},
                               {"And", "Kaj"},
                               {"Then", "Do"},
                               {"Examples", "Ekzemploj"}
                           };
        }
    }
}
