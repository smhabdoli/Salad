using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ko
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
            Language = "ko";

            _locales = new Hashtable
                           {
                               {"Feature", "기능"}, 
                               {"Scenario", "시나리오 개요"},
                               {"Scenario1", "시나리오"},
                               {"Given", "조건"},
                               {"When", "만일"},
                               {"And", "그리고"},
                               {"Then", "그러면"},
                               {"Examples", "예"}
                           };
        }
    }
}
