using GestionSupermercado.Intefaces;
using GestionSupermercado.Modelos;

namespace GestionSupermercado
{
    class Program
    {
        static void Main()
        {
            List<IProducto> productosSupermercado = new List<IProducto>
            {
                new ProductoAlimento("pizza", 20),
                new ProductoElectronica("laptop", 100),
                new ProductoRopa("jean", 50)
            };

            foreach (var producto in productosSupermercado)
            {
                producto.MostrarDetalles();
            }

        }
    }
}