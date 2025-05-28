using finance_app.Models;
using Microsoft.EntityFrameworkCore;

namespace finance_app.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
        { }

        DbSet<Expense> Expenses { get; set; }
    }
}