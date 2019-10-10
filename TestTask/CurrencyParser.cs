using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace TestTask
{
    public class CurrencyParser
    {
        public static IEnumerable<Currency> GetCurrenciesFromURL(string url, DateTime currentDate)
        {
            url += currentDate;
            XmlTextReader reader = new XmlTextReader(url);
            var currencies = new List<Currency>();
            reader.ReadStartElement();
            
            while (reader.Name == "Valute")
            {
                XElement el = (XElement)XNode.ReadFrom(reader);
                var currency = new Currency
                {
                    Date = currentDate
                };
                foreach (XElement node in el.Nodes())
                {
                    if (node.Name == "CharCode")
                        currency.Name = node.Value;
                    else if (node.Name == "Value")
                        currency.Value = double.Parse(node.Value);
                }
                currencies.Add(currency);
            }
            return currencies;
        }
    }
}
