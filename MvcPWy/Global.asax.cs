using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcPWy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            try
            {
                HttpContext.Current.GetOwinContext().Authentication.SignOut();
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        void Session_End(object sender, EventArgs e)
        {
            try
            {
                HttpContext.Current.GetOwinContext().Authentication.SignOut();
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        protected void Application_EndRequest()
        {
            try
            {
                HttpContext.Current.GetOwinContext().Authentication.SignOut();
            }
            catch (Exception exception)
            {

                throw;
            }
        }

        //Application_EndRequest
        //Session_End
        //Application_End
        //Application_Error
    }
}
