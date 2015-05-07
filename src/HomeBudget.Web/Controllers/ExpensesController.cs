using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Contracts.Expenses;
using HomeBudget.Contracts.Grids;
using HomeBudget.Domain;
using HomeBudget.Logic.Expenses;

namespace HomeBudget.Web.Controllers
{
    public class ExpensesController : BaseController
    {
        public ActionResult Index()
        {
            return View(ExpensesRootViewModelFactory.Create());
        }
    }
}