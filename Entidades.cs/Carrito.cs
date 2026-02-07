namespace Entidades.cs
{
    public class Carrito : IOperable
    {
        //campos
        private Comprador comprador;
        private List<Publicacion> publicaciones;

        //propiedades
        public Comprador Comprador
        {
            get => comprador;
            set => comprador = value;
        }
        //constructor
        public Carrito(Comprador comprador)
        {
            this.comprador = comprador;
            publicaciones = new List<Publicacion>();

        }
        //metodos
        public void AddPublicacion(Publicacion publicacion)
        {
            publicaciones.Add(publicacion);
        }
        //metodo para obtener la lista de publicaciones
        public List<Publicacion> GetPublicaciones()
        {
            return  publicaciones;
        }

        //metodo para limpiar el carrito
        public void ClearPublicaciones()
        {
            publicaciones.Clear();
        }

        //implementacion CalcularTotal : herencia
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Publicacion publicacion in publicaciones)
            {
                total += publicacion.Precio;
            }
            return total;
        }

        //Sobrescritura ToString
        public override string ToString()
        {
            return $"Carrito con {publicaciones.Count} productos - valor:{this.CalcularTotal()}";
        }


    }

}
