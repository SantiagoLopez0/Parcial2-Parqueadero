using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Parqueadero.Models
{
    public class Vehicle
    {
        private string placa;
        private static string[] TIPO = { "PARTICULAR", "CAMIONETA O MICROBUS" };
        
        private string marca;

        public Vehicle(string placa, string tipo, string marca)
        {
            this.Placa = placa;
            this.Marca = marca;
        }


        public string Placa { get => placa; set => placa = value; }
        //public static string[] TIPO1 { get => TIPO; set => TIPO = value; }
        public string Marca { get => marca; set => marca = value; }

        
    }
}