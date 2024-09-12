using GestionSupermercado.Enums;
using GestionSupermercado.Intefaces;

namespace GestionSupermercado.Modelos
{
    public class ProductoElectronica : IProducto 
    {
        public string Nombre { get; set; }
        public double Precio {  get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }

        public ProductoElectronica(string nombre, double precio) 
        {
            Nombre = nombre;
            Precio = precio;
            CategoriaProducto = CategoriaProducto.Electronica;
        }    

        public void MostrarDetalles()
        {
            Console.WriteLine($"{CategoriaProducto} - Nombre: {Nombre}, Precio: {Precio:C}");
        }

    }
}
