using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadTienda;
using AccesoTienda;
using Crud;
using System.Drawing;

namespace ManejadorTienda
{
    public class ManejadorProductos : Interface1
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(String.Format("¿Estas seguro de borrar? {0}", Entidad.IdProducto),
                "!Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Producto Guardado", "¡ATENCIÓN!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
        }
    }
}
