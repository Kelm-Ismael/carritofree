using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.cs
{
    public class FreeMarket
    {
        //campos
        private static List<Publicacion> publicaciones = new List<Publicacion>();
        private static List<Comprador> compradores = new List<Comprador>();

        //metodos
        public static void AddPublicacion(Publicacion publicacion)
        {
            publicaciones.Add(publicacion);
            
        }

        public static void AddComprador(Comprador comprador)
        {
            compradores.Add(comprador);
        }

        public static List<Publicacion> GetPublicaciones()
        {
            return publicaciones;
        }

        public static List<Comprador> GetCompradores()
        {
            return compradores;
        }



    }
}
