using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeBudget.Web.Controllers
{
    public class ExpensesController : BaseController
    {
        /// <summary>
        /// ONLY FOR INFRASTRUCTURE TEST    
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}