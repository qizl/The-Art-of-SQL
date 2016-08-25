using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TheArtofSQL.Models;

namespace TheArtofSQL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //System.Data.Entity.Database.SetInitializer<TAOSDBContext>(new InitializeDB()); // 初始化数据库结构与数据

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
