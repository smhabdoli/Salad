using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ja
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
            Language = "ja";

            _locales = new Hashtable
                           {
                               {"Feature", "フィーチャ"}, 
                               {"Scenario", "シナリオテンプレート"},
                               {"Scenario1", "シナリオ"},
                               {"Given", "前提"},
                               {"When", "もし"},
                               {"And", "かつ"},
                               {"Then", "ならば"},
                               {"Examples", "例"}
                           };
        }
    }
}
