using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPracticeSite.Controllers
{   
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// GET: /HelloWorld/Welcome?name=Scott&id=4 使用查询字符串 QueryString
        /// or Get:  HelloWorld/Welcome/Scott/3(添加了name MapRoute后才可使用)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        //public string Welcome(string name, int ID = 1)
        //{
        //    //HttpServerUtility.HtmlEncode 来保护应用从malacious输入的(也就是JavaScript)
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID);
        //}
        public ActionResult Welcome(string name, int ID = 1)
        {
            //ViewBag 对象包含了数据，并将自动传递给视图模板
            ViewBag.Message = "Hello " + name;
            ViewBag.ID = ID;
            return View();
        }
    }   
}