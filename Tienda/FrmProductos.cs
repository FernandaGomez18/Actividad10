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
        public static Productos
            productos = new Productos(0, "", "","","");
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if(productos.IdProducto>0)
            {
                txtNombre.Text = productos.Nombre;
                txtDescripcion.Text = productos.Descripcion;
                txtPrecio.Text = productos.Precio;
                txtProveedor.Text = productos.Proveedor;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos(productos.IdProducto
                , txtNombre.Text,
                txtDescripcion.Text,txtPrecio.Text, txtProveedor.Text
                ));
            Close();
        }
    }
}
