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
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        /// <summary>
        /// GET: /HelloWorld/Welcome?name=Scott&id=4
        /// or Get:  HelloWorld/Welcome/Scott/3(添加了name MapRoute后才可使用)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        public string Welcome(string name, int ID = 1)
        {
            //HttpServerUtility.HtmlEncode 来保护应用从malacious输入的(也就是JavaScript)
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID);
        }
    }   
}