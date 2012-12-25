using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Lt
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
            Language = "lt";

            _locales = new Hashtable
                           {
                               {"Feature", "Savybė"}, 
                               {"Scenario", "Scenarijaus šablonas"},
                               {"Scenario1", "Scenarijus"},
                               {"Given", "Duota"},
                               {"When", "Kai"},
                               {"And", "Ir"},
                               {"Then", "Tada"},
                               {"Examples", "Pavyzdžiai"}
                           };
        }
    }
}
