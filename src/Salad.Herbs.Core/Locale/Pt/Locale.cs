using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Pt
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
            Language = "pt";

            _locales = new Hashtable
                           {
                               {"Feature", "Funcionalidade"}, 
                               {"Scenario", "Cenário"},
                               {"Given", "Dado"},
                               {"When", "Quando"},
                               {"And", "E"},
                               {"Then", "Então"},
                               {"Examples", "Exemplos"}
                           };
        }
    }
}
