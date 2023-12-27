using enterprise_expenses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace enterprise_expenses.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            // Last 7 days

            DateTime StartDate = DateTime.Today.AddDays(-6);
            DateTime EndDate = DateTime.Today;

            List<Transaction> SelectedTransactions = await _context.Transactions
                .Include(t => t.Category)
                .Where(t => t.Date >= StartDate && t.Date <= EndDate)
                .ToListAsync();

            // Total Income

            int TotalIncome = SelectedTransactions
                .Where(t => t.Category.Type == "Income")
                .Sum(t => t.Amount);

            ViewBag.TotalIncome = TotalIncome.ToString("C0");

            // Total Expenses

            int TotalExpenses = SelectedTransactions
                .Where(t => t.Category.Type == "Expense")
                .Sum(t => t.Amount);

            ViewBag.TotalExpenses = TotalExpenses.ToString("C0");

            // Total Balance

            int TotalBalance = TotalIncome - TotalExpenses;

            ViewBag.TotalBalance = TotalBalance.ToString("C0");

            return View();
        }
    }
}
