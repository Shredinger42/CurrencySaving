using System;
using System.Threading;

namespace TestTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            var url = "http://www.cbr.ru/scripts/XML_daily.asp?date_req=";
            do
            {
                var currentDay = DateTime.Today;
                var currencies = CurrencyParser.GetCurrenciesFromURL(url, currentDay);
                DataBase.WriteDataIntoDB(currencies);
                Thread.Sleep(24 * 60 * 60 * 1000); //Ждем сутки чтобы на следующий день записать новые значения
            } while (true);
        }        
    }
}