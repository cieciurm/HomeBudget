using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Contracts.Expenses;
using HomeBudget.Contracts.Grids;
using HomeBudget.Domain;

namespace HomeBudget.Web.Controllers
{
    public class ExpensesController : BaseController
    {
        public static string ExpensesGridId = "ExpensesGridId";

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Grid()
        {
            var grid = new GridViewModelBase<ExpenseViewModel>(ExpensesGridId);
            grid.AddColumn(e => e.Category.Name, "Category")
                .AddColumn(e => e.Amount, "Expense")
                .AddColumn(e => e.ExpenseDate, "Date")
                .AddColumn(e => e.Account.Name, "Account")
                .AddColumn(e => e.Comment, "Comment");

            return JsonNetResult(grid);
        }
    }
}