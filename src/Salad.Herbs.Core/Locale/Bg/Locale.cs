using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Bg
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
            Language = "bg";

            _locales = new Hashtable
                           {
                               {"Feature", "Функционалност"}, 
                               {"Scenario", "Рамка на сценарий"},
                               {"Scenario1", "Сценарий"},
                               {"Given", "Дадено"}, 
                               {"When", "Когато"},
                               {"And", "И"},
                               {"Then", "То"}
                           };
        }
    }
}
