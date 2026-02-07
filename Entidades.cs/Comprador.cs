using Entidades.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class Comprador : Entidad
    {

        //campos
        private List<Operacion> operaciones;
        private int dni;

        //propiedades
        public int Dni
        {
            get => dni;
            set
            {
                // DNI entre 1.000.000 y 99.999.999
                if (value < 1000000 || value > 99999999)
                {
                    throw new ArgumentException($"Error.El DNI debe ser un número entre 1.000.000 y 99.999.999");
                }
                dni = value;
            }
        }
        //propiedad carrito actual
        public Carrito CarritoActual { get; internal set; }

        //constructor

        public Comprador(string nombre, int dni) : base(nombre)
        {
            Dni = dni;
            operaciones = new List<Operacion>();
        }


        //metodos
        //obtener operaciones
        public List<Operacion> GetOperaciones()
        {
            return operaciones;
        }
        //agregar operacion
        internal void AddOperacion(Operacion operacion)
        {
            operaciones.Add(operacion);
        }
        //sobrescritura ToString
        public override string ToString()
        {
            return $"Nombre:  {Nombre} - Dni({dni})";
        }

    }


    //public class Comprador : Entidad
    //{
    //    // Campos
    //    private List<Operacion> operaciones;
    //    private int dni;

    //    // Propiedades
    //    public int Dni
    //    {
    //        get => dni;
    //        set
    //        {
    //            // DNI entre 1.000.000 y 99.999.999
    //            if (value < 1000000 || value > 99999999)
    //            {
    //                throw new ArgumentException("Error. El DNI debe ser un número entre 1.000.000 y 99.999.999");
    //            }
    //            dni = value;
    //        }
    //    }
    //    public Carrito CarritoActual { get; internal set; }

    //    // Constructor
    //    public Comprador(string nombre, int dni) : base(nombre)
    //    {
    //        Dni = dni;
    //        operaciones = new();
    //    }

    //    // Métodos
    //    internal void AddOperacion(Operacion operacion)
    //    {
    //        operaciones.Add(operacion);
    //    }
    //    public List<Operacion> GetOperaciones()
    //    {
    //        return operaciones;
    //    }

    //    // ToString
    //    public override string ToString()
    //    {
    //        return $"{Nombre} ({Dni})";
    //    }
    //}
}
