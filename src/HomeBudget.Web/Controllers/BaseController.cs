using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Mapping.Abstraction;
using HomeBudget.Web.Configuration;
using HomeBudget.Web.Results;
using Microsoft.Practices.Unity;

namespace HomeBudget.Web.Controllers
{
    public class BaseController : Controller
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }

        protected JsonResult JsonNetResult(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }

        protected JsonResult JsonNetResult(object data)
        {
            return new JsonNetResult
            {
                Data = data,
                ContentType = Const.ContentType.Json,
                ContentEncoding = Encoding.UTF8,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}