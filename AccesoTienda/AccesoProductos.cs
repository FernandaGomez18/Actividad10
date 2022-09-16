using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadTienda;
using ConectarBd;
namespace AccesoTienda
{
    public class AccesoProductos : IEntidades
    {
        Base b = new Base("localhost", "root", "Fernanda2002", "Tienda");
        public void Borrar(dynamic Entidad)
        {

            b.Comando(string.Format("call p_EliminarProducto({0})", Entidad.IdProducto));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call  p_insertarProducto({0},'{1}','{2}','{3}','{4}')", Entidad.IdProducto, Entidad.Nombre,
                 Entidad.Descripcion,Entidad.Precio,Entidad.Proveedor));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("select * from productos;", filtro), "productos");
        }
    }
}
