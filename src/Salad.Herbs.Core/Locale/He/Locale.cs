using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.He
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
            Language = "he";

            _locales = new Hashtable
                           {
                               {"Feature", "תכונה"}, 
                               {"Scenario", "תבנית תרחיש"},
                               {"Scenario1", "תרחיש"},
                               {"Given", "בהינתן"},
                               {"When", "כאשר"},
                               {"And", "וגם"},
                               {"Then", "אז"},
                               {"Examples", "דוגמאות"}
                           };
        }
    }
}
