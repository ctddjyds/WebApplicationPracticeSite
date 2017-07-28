using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationPracticeSite.Controllers;

namespace WebApplicationPracticeSite.Areas.SysManage.Controllers
{
    public class PermissionController : BaseController
    {
        #region 声明容器
         /// <summary>
         /// 系统管理
        /// </summary>
         ISystemManage SystemManage { get; set; }
         /// <summary>
         /// 权限管理
         /// </summary>
         IPermissionManage PermissionManage { get; set; }
         /// <summary>
         /// 模块管理
         /// </summary>
         IModuleManage ModuleManage { get; set; }
         #endregion
        // GET: SysManage/Permission
        public ActionResult Index()
        {
            return View();
        }
    }
}