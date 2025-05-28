using finance_app.Models;

namespace finance_app.Data.Services
{
    public interface IExpensesService
    {
        Task<IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);
    }
}