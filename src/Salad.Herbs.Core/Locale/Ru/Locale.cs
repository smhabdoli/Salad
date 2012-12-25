using System.Collections;
using System.Collections.Generic;

namespace Salad.Herbs.Core.Locale.Ru
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
            Language = "ru";

            _locales = new Hashtable
                           {
                               {"Feature", "Функционал"},
                               {"Feature1", "Функция"},
                               {"Scenario", "Структура сценария"},
                               {"Scenario1", "Сценарий"},
                               {"Background", "Предыстория"},
                               {"Given", "Допустим"},
                               {"When", "Если"},
                               {"And", "И"},
                               {"Then", "То"},
                               {"Examples", "Примеры"}
                           };
        }
    }
}
