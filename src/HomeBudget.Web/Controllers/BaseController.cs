using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Mapping.Abstraction;
using Microsoft.Practices.Unity;

namespace HomeBudget.Web.Controllers
{
    public class BaseController : Controller
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }
    }
}