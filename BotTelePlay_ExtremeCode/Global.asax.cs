using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BotTelePlay_ExtremeCode.Models;

namespace BotTelePlay_ExtremeCode
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); //Удаленно за ненадобностью
            GlobalConfiguration.Configure(WebApiConfig.Register); //подключение маршрутизации для API контроллера
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles); //Удаленно за ненадобностью

            //ДЛЯ того чтоб работал WEB HOOK необходимо выполнить первичную инициализацию Бота !
            Bot.Get();
        }
    }
}
