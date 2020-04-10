using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MoneyConverter
{
    class OnlineRates
    {
        public static double GetDollar()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ValCurs));
            XmlReader xr = new XmlTextReader(@"http://www.cbr.ru/scripts/xml_daily.asp");
            var valuteCurs = (ValCurs)xs.Deserialize(xr);
            for (int i = 0; i < valuteCurs.valuteList.Length; i++)
            {
                ValCursValute valute = valuteCurs.valuteList[i];
                if (valute.Name == "Доллар США")
                    return double.Parse(valute.Value);
            }
            return 0;
        }
        public static double GetEuro()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ValCurs));
            XmlReader xr = new XmlTextReader(@"http://www.cbr.ru/scripts/xml_daily.asp");
            var valuteCurs = (ValCurs)xs.Deserialize(xr);
            for (int i = 0; i < valuteCurs.valuteList.Length; i++)
            {
                ValCursValute valute = valuteCurs.valuteList[i];
                if (valute.Name == "Евро")
                    return double.Parse(valute.Value);
            }
            return 0;
        }
    }
}
