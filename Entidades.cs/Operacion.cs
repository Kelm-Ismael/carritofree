using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Operacion
    {
        //campos
        private Comprador comprador;
        private decimal Monto = 0;

        //propiedades

        public IOperable Operable { get; internal set; } //AGREGUE INTERNAL PARA QUE SOLO SE PUEDA ASIGNAR DESDE LA CLASE CARRO, YA QUE ES LA UNICA QUE CREA OPERACIONES
        public DateTime Fecha { get; set; }
        public decimal monto { get => Operable.CalcularTotal(); }
        

        public Comprador Comprador
        {
            get => comprador;
            set
            {
                comprador = value;//verificar si esta bien asi o alreves 
                value.AddOperacion(this);
            }

        }

        //constructor
        public Operacion(Comprador comprador, DateTime fecha,IOperable operable)
        {
            Comprador = comprador;
            Fecha = fecha;
            Operable = operable;
        }

        //sobrescritura ToString
        public override string ToString()
        {
            return $"{comprador} - Fecha: {Fecha} - Monto: { monto}";
        }


    }
}
