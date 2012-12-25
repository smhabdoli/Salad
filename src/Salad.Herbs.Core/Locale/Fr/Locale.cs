using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Fr
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
            Language = "fr";

            _locales = new Hashtable
                           {
                               {"Feature", "Fonctionnalité"}, 
                               {"Scenario", "Plan du Scénario"},
                               {"Scenario1", "Scénario"},
                               {"Given", "Soit"},
                               {"When", "Lorsque"},
                               {"And", "Et"},
                               {"Then", "Alors"},
                               {"Examples", "Exemples"}
                           };
        }
    }
}
