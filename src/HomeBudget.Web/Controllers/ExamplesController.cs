using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Web.Models.ExampleModels;
using HomeBudget.Web.Results;

namespace HomeBudget.Web.Controllers
{
    public class ExamplesController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TestCamelcase()
        {
            var model = new CamelCaseTestModel
            {
                AnArray = new[] { "Value1", "Value2", "Value3" },
                AnotherIntegerValue = 999,
                FirstName = "Jaroslaw"
            };

            return JsonNetResult(model);
        }

        [HttpPost]
        public JsonResult TestCamelcaseBinding(CamelCaseTestModel model)
        {
            if(model.AnArray == null || model.AnotherIntegerValue == 0)
                throw new Exception("Json.NET model binding error");

            return JsonNetResult("success");
        }
    }
}