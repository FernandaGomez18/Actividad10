using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadTienda
{
    public class Productos
    {
        public Productos(int idProducto, string nombre, string descripcion, string precio)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
    }
}
