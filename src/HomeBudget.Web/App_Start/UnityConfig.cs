using System.Web.Mvc;
using HomeBudget.Mapping;
using HomeBudget.Mapping.Abstraction;
using HomeBudget.Mapping.Implementation;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace HomeBudget.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<HomeBudgetContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, HomeBudgetContext>();
            container.RegisterType<IContext, HomeBudgetContext>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}