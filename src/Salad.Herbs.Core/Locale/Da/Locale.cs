using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Da
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
            Language = "da";

            _locales = new Hashtable
                           {
                               {"Feature", "Egenskab"}, 
                               {"Scenario", "Scenarie"},
                               {"Given", "Givet"}, 
                               {"When", "Når"},
                               {"And", "Og"},
                               {"Then", "Så"}
                           };
        }
    }
}
