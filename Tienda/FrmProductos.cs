using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorTienda;
using EntidadTienda;
namespace Tienda
{
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
     
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if(FrmProductoAdd.producto.IdProducto>0)
            {
                txtNombre.Text =FrmProductoAdd.producto.Nombre;
                txtDescripcion.Text = FrmProductoAdd.producto.Descripcion;
                txtPrecio.Text = FrmProductoAdd.producto.Precio;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos(FrmProductoAdd.producto.IdProducto
                , txtNombre.Text,
                txtDescripcion.Text,txtPrecio.Text
                ));
            Close();
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
