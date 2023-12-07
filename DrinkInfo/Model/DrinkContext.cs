using DrinkInfo.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkInfo
{
    public class DrinkContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source = favourite_drinks.db");
        }
    }
}
