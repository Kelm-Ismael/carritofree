using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public abstract class Entidad
    {
        //campos
        private string nombre;

        //propiedades
        public string Nombre
        {
            get => nombre; // devuelve el valor del campo nombre
            set
            {
                if (value.Length < 3) // validacion de nombre que reciba
                {
                    throw new Exception("El nombre debe tener al menos 3 caracteres.");
                }
               
                nombre = value;
            }
             
        }
        //constructor
        public Entidad(string nombre)
        {
            this.Nombre = nombre;
        }



    }
}
