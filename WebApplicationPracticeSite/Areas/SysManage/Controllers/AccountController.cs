using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.IService;
using Common;

namespace WebApplicationPracticeSite.Areas.SysManage.Controllers
{
    public class AccountController : Controller
    {
        #region 声明容器
        /// <summary>
        /// 用户管理
        /// </summary>
        IUserManage UserManage { get; set; }
        log4net.Ext.IExtLog log = log4net.Ext.ExtLogManager.GetLogger("dblog");
        #endregion
        // GET: SysManage/Account
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        [ValidateAntiForgeryToken]
        public ActionResult Login(Domain.SYS_USER item)
        {
            var json = new JsonHelper() { Msg = "登录成功", Status = "n" };
            try
            {
                //调用登录验证接口 返回用户实体类
                var users = UserManage.UserLogin(item.ACCOUNT.Trim(), item.PASSWORD.Trim());
                if (users != null)
                {
                    //是否锁定
                    if (users.ISCANLOGIN == 1)
                    {
                        json.Msg = "用户已锁定，禁止登录，请联系管理员进行解锁";
                        return Json(json);
                    }
                    json.Status = "y";

                }
                else
                {
                    json.Msg = "用户名或密码不正确";
                }

            }
            catch (Exception e)
            {
                json.Msg = e.Message;
                log.Error(Utils.GetIP(), item.ACCOUNT, Request.Url.ToString(), "Login", "系统登录，登录结果：" + json.Msg);
            }
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}