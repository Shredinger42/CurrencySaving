using System.Collections.Generic;
using System;
namespace TestTask
{
    class DataBase
    {
        public static void WriteDataIntoDB(IEnumerable<Currency> dataCollection)
        {
            using (var db = new CurrencyContext())
            {
                Console.WriteLine("Начинается запись в базу данных.");
                foreach (var data in dataCollection)
                {
                    db.Currencies.Add(data);
                }
                Console.WriteLine("Запись окончена. Начинается сохранение.");
                db.SaveChanges();
                Console.WriteLine("Сохранение завершено");
            }
        }
    }
}
