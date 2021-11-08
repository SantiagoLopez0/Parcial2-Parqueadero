using Parcial2_Parqueadero.Models;
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
    public class DriverController : Controller
    {
        static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "F3M3ArKMwJSFyyWngKxJNPHKGIH9G3ZeO90XELXw",
            BasePath = "https://parcial2-886da-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);

        // GET: Driver
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            

            List<String> sexo = new List<string>();
            sexo.Add("Hombre");
            sexo.Add("Mujer");
            sexo.Add("Otro");

            ViewBag.sexoConductor = new SelectList(sexo);

            return View();
        }

        [HttpPost]
        public ActionResult Create(Driver driver)
        {
            Driver _driver = new Driver();

            _driver.Identificador = driver.Identificador;
            _driver.Nombre = driver.Nombre;
            _driver.Sexo = driver.Sexo;
            _driver.EsAfiliado = driver.EsAfiliado;

            try
            {
                client.Set("DriverList/"+ _driver.Identificador, _driver);
                return Json(new { mensaje = "Solicitud creada.", error = "1" });
            }
            catch(Exception e)
            {
                return Json(new { mensaje = "Error al crear la solicitud", error = "2" });
            }
        }
    }
}