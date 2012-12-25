using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Id
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
            Language = "id";

            _locales = new Hashtable
                           {
                               {"Feature", "Fitur"}, 
                               {"Scenario", "Skenario konsep"},
                               {"Scenario1", "Skenario"},
                               {"Given", "Dengan"},
                               {"When", "Ketika"},
                               {"And", "Dan"},
                               {"Then", "Maka"},
                               {"Examples", "Contoh"}
                           };
        }
    }
}
