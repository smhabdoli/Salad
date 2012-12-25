using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.It
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
            Language = "it";

            _locales = new Hashtable
                           {
                               {"Feature", "Funzionalità"}, 
                               {"Scenario", "Scenario"},
                               {"Given", "Dato"},
                               {"When", "Quando"},
                               {"And", "E"},
                               {"Then", "Allora"},
                               {"Examples", "Esempi di"}
                           };
        }
    }
}
