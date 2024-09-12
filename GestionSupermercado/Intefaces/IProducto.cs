using GestionSupermercado.Enums;

namespace GestionSupermercado.Intefaces
{
    public interface IProducto
    {
        string Nombre { get; set; }
        double Precio { get; set; }
        CategoriaProducto CategoriaProducto { get; set; }

        void MostrarDetalles();
    }
}
