using Entidades.cs;

namespace freemarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t------------ Free Market ----------\n");

            Comprador comprador1 = new("Juan", 12345678);
            Comprador comprador2 = new("Pedro", 87654321);
            Comprador comprador3 = new("Simon", 11223346);
            Console.WriteLine(comprador1);

            //exepcion para DNI fuera de rango
            try
            {
                Comprador comprador4 = new("Luz", 20000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Primera Excepcion: " + ex.Message);
            }
            Console.WriteLine();

            Publicacion publicacion1 = new("gaseosa", 1500, 10);
            Publicacion publicacion2 = new("agua", 650, 20);
            Publicacion publicacion3 = new("harina", 1900, 45);
            Publicacion publicacion4 = new("queso", 1900, 45);
            Publicacion publicacion5 = new("yerba", 1900, 45);

            Console.WriteLine();

            Console.WriteLine(publicacion1);

            try
            {
                Publicacion publicacion6 = new("shampoo",0 ,1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Segunda Excepcion: " + ex.Message);
            }

            //primera operacion
            Operacion operacion1 = new(comprador1, DateTime.Now, publicacion1);
            Console.WriteLine("\nPrimera Operacion de Publicacion ");
            Console.WriteLine(operacion1);
           
            //crear un carrito

            Carrito carrito1 = new(comprador2);
            carrito1.AddPublicacion(publicacion1);
            carrito1.AddPublicacion(publicacion2);
            carrito1.AddPublicacion(publicacion3);
            carrito1.AddPublicacion(publicacion4);
            Console.WriteLine();
            Console.WriteLine(carrito1);

            //crear una operacion con el carrito

            Operacion operacion2 = new(carrito1.Comprador, DateTime.Now, carrito1);
            Console.WriteLine("\nSegunda Operacion carrito con varias Publicaciones ");
            Console.WriteLine(operacion2);

            //agregar compradores al FreeMarket

            FreeMarket.AddComprador(comprador1);
            FreeMarket.AddComprador(comprador2);
            FreeMarket.AddComprador(comprador3);

            //agregar publicaciones al FreeMarket

            FreeMarket.AddPublicacion(publicacion1);
            FreeMarket.AddPublicacion(publicacion2);
            FreeMarket.AddPublicacion(publicacion3);
            FreeMarket.AddPublicacion(publicacion4);
            FreeMarket.AddPublicacion(publicacion5);

            //Mostrar Publicaciones

            MostrarPublicaciones();

            MostrarCompradores();


        }

        private static void MostrarPublicaciones()
        {
            Console.WriteLine("\nLista de Publiacaciones");
            foreach (Publicacion publicacion in FreeMarket.GetPublicaciones())
            {
                Console.WriteLine(publicacion);
            }

        }

        private static void MostrarCompradores()
        {
            Console.WriteLine("\n=== Lista de Compradores ===");

            foreach (var comprador in FreeMarket.GetCompradores())
            {
                Console.WriteLine($"\nComprador: {comprador}");
                Console.WriteLine("Operaciones:");

                foreach (var operacion in comprador.GetOperaciones())
                {
                    Console.WriteLine($"  - {operacion}");
                }
            }
        }


    }
}
