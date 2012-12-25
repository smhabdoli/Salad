using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Hu
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
            Language = "hu";

            _locales = new Hashtable
                           {
                               {"Feature", "Jellemző"}, 
                               {"Scenario", "Forgatókönyv vázlat"},
                               {"Scenario1", "Forgatókönyv"},
                               {"Given", "Megadott"},
                               {"Given1", "Adott"}
                               {"When", "Majd"},
                               {"And", "És"},
                               {"Then", "Akkor"},
                               {"Examples", "Példák"}
                           };
        }
    }
}
