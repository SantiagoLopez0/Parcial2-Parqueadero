using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Parcial2_Parqueadero.Controllers
{
    public class HomeController : Controller
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "F3M3ArKMwJSFyyWngKxJNPHKGIH9G3ZeO90XELXw",
            BasePath = "https://parcial2-886da-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public ActionResult Index()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection Error");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}