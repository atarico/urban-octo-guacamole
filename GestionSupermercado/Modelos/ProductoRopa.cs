using GestionSupermercado.Enums;
using GestionSupermercado.Intefaces;

namespace GestionSupermercado.Modelos
{
    public class ProductoRopa : IProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }

        public ProductoRopa(string nombre, double precio) 
        {
            Nombre = nombre;
            Precio = precio;
            CategoriaProducto = CategoriaProducto.Ropa;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"{CategoriaProducto} - Nombre: {Nombre}, Precio: {Precio:C}");
        }
    }
}
