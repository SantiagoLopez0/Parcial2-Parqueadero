using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Parqueadero.Models
{
    public class Vehicle
    {
        private string placa;
        private string tipo;
        private string marca;
        private int driverId;


        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int DriverId { get => driverId; set => driverId = value; }
    }
}