using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TurkTicaretCRM.Core.Utilities.Mvc.Infrastructure;
using TurkTicaretCRM.TT.Bussiness.DependencyResolvers.Ninject;

namespace TurkTicaretCRM.TT.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BussinessModule()));
        }
    }
}
