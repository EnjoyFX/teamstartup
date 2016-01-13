using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Microsoft.Practices.ServiceLocation;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;

namespace Smart.PL.WebUI.Frontend
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            
            container.RegisterType<IStartupMarketService, StartupMarketService>();
            container.RegisterType<IJobMarketService, JobMarketService>();
            container.RegisterType<IInvestorService, InvestorService>();
            container.RegisterType<IStartupService, StartupService>();
            container.RegisterType<IStatisticService, StatisticService>();
            container.RegisterType<ICallToActionService, CallToActionService>();

            container.RegisterType<IServiceLocator, UnityServiceLocator>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}