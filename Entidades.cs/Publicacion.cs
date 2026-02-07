using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Publicacion : Entidad, IOperable
    {
        //campos
        private decimal precio;
        private bool habilitada = true ;

        //propiedades

        public decimal Precio
        {
            get => precio;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error! El precio debe ser mayor a cero");
                }
                precio = value;
            }
        }
        
        //propiedad habilitada
        public bool Habilitada
        {
            get => habilitada;
            set
            {
                habilitada = value;
            }
        }
        public int Stock { get; set; }


        //constructor

        public Publicacion(string nombre, decimal precio, int stock) : base(nombre)
        {

            Precio = precio;
            Stock = stock;
        }
        //sobrecarga constructor
        public Publicacion(string nombre, decimal precio, int stock, bool habilitada) : this(nombre, precio, stock)
        {
            Habilitada = true;
        }
        //metodos 
        public decimal CalcularTotal()
        {
            return Precio;
        }
        //sobrescritura ToString
        public override string ToString()
        {
            return $"Publicacion:   {Nombre} - Valor: ${this.CalcularTotal()}";
            
        }

    }
}
