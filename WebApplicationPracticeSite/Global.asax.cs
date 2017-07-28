using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplicationPracticeSite
{
    /// <summary>
    /// SpringMvcApplication 使spring.net的容器接管启动
    /// </summary>
    public class MvcApplication : Spring.Web.Mvc.SpringMvcApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//配置区域路由 目的在大型复杂网站下方便管理路由
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//配置过滤特性
            RouteConfig.RegisterRoutes(RouteTable.Routes);//配置传统路由          
            BundleTable.EnableOptimizations = true;//启用压缩
            BundleConfig.RegisterBundles(BundleTable.Bundles);//配置捆绑压缩的JS和css文件
        }
    }
}
