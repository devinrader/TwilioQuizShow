using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TwilioQuizShow.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            WebClient client = new WebClient();

            string token = String.Empty;

            try
            {
                token = client.DownloadString(ConfigurationManager.AppSettings["TokenGeneratorUrl"]);
            }
            catch (Exception exc)
            {
                // Eat this exception.  In a real app, you should surface this to the View
            }

            ViewBag.token = token;

            return View();
        }

    }
}
