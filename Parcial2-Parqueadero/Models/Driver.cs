using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Parqueadero.Models
{
    public class Driver
    {
        private int identificador;
        private string nombre;
        private string sexo;
        private Boolean esAfiliado;

        public int Identificador { get => identificador; set => identificador = value; }
        
        public bool EsAfiliado { get => esAfiliado; set => esAfiliado = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}