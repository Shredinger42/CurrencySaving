using System.Data.Entity;

namespace TestTask
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext()
            : base("Currencies")
        { }

        public DbSet<Currency> Currencies { get; set; }
    }
}
