using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Parcial2_Parqueadero.Models;

namespace Parcial2_Parqueadero.Controllers
{
    public class VehicleController : Controller
    {
        static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "F3M3ArKMwJSFyyWngKxJNPHKGIH9G3ZeO90XELXw",
            BasePath = "https://parcial2-886da-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            List<String> tipo = new List<string>();
            tipo.Add("Particular");
            tipo.Add("Camioneta o Microbus");

            ViewBag.tipoVehiculo = new SelectList(tipo);

            return View();
        }

        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            Vehicle _vehicle = new Vehicle();

            _vehicle.DriverId = vehicle.DriverId;
            _vehicle.Placa = vehicle.Placa;
            _vehicle.Tipo = vehicle.Tipo;
            _vehicle.Marca = vehicle.Marca;

            try
            {
                client.Set("VehicleList/" + _vehicle.Placa, _vehicle);
                return Json(new { mensaje = "Solicitud creada.", error = "1" });
            }
            catch (Exception e)
            {
                return Json(new { mensaje = "Error al crear la solicitud", error = "2" });
            }
        }

        [HttpPost]
        public ActionResult SearchDriver(string driverId)
        {
            int _driverId = Convert.ToInt32(driverId);

            try
            {
                FirebaseResponse response = client.Get("DriverList/" + _driverId);
                Driver d = response.ResultAs<Driver>();

                if (d != null)
                {
                    return Json(new { mensaje = "Conductor encontrado", nombre = d.Nombre, error = "1" });
                }
                else return Json(new { mensaje = "El conductor no se encuentra registrado.", error = "2" });
            }
            catch(Exception e)
            {
                return Json(new { mensaje = "Error en conexión a la base de datos", error = "3" });
            }
            
        }
    }
}