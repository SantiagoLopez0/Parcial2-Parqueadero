using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Parqueadero.Models
{
    public class Driver
    {
        private int id;
        private Sexo sexo;
        private Boolean esAfiliado;

        public Driver(int id, string sexo, Boolean esAfiliado)
        {
            this.Id = id;

            if(sexo == "hombre")
            {
                this.Sexo = Sexo.HOMBRE;
            }
            else if (sexo == "mujer")
            {
                this.Sexo = Sexo.MUJER;
            }
            else if (sexo == "otro")
            {
                this.Sexo = Sexo.OTRO;
            }

            this.EsAfiliado = esAfiliado;
        }

        public int Id { get => id; set => id = value; }
        
        public bool EsAfiliado { get => esAfiliado; set => esAfiliado = value; }
        internal Sexo Sexo { get => sexo; set => sexo = value; }
    }
}