using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Es
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
            Language = "es";

            _locales = new Hashtable
                           {
                               {"Feature", "Característica"}, 
                               {"Scenario", "Esquema del escenario"},
                               {"Scenario1", "Escenario"},
                               {"Given", "Dado"},
                               {"When", "Cuando"},
                               {"And", "Y"},
                               {"Then", "Entonces"},
                               {"Examples", "Ejemplos"}
                           };
        }
    }
}
