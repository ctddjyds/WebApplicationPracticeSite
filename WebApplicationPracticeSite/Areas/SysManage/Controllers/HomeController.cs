using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationPracticeSite.Controllers;
using Service.IService;

namespace WebApplicationPracticeSite.Areas.SysManage.Controllers
{
    public class HomeController : BaseController
    {
        IModuleManage ModuleManage { get; set; }
        // GET: SysManage/Home
        public ActionResult Index()
        {
            //获取系统模块列表
            ViewData["Module"] = ModuleManage.GetModule(this.CurrentUser.Id, this.CurrentUser.Permissions, this.CurrentUser.System_Id);
            return View(this.CurrentUser);
        }
    }
}