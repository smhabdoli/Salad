using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Pl
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
            Language = "pl";

            _locales = new Hashtable
                           {
                               {"Feature", "Właściwość"}, 
                               {"Scenario", "Szablon scenariusza"},
                               {"Scenario1", "Scenariusz"},
                               {"Given", "Zakładając"},
                               {"When", "Jeżeli"},
                               {"And", "Oraz"},
                               {"Then", "Wtedy"},
                               {"Examples", "Przykłady"}
                           };
        }
    }
}
