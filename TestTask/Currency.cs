using System;
using System.ComponentModel.DataAnnotations;

namespace TestTask
{
    public class Currency
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
