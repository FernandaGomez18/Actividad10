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
    public partial class FrmProductoAdd : Form
    {
        ManejadorProductos mp;
        public static Productos producto = new Productos(0, "", "", "");
        int fila = 0, col = 0;
        public FrmProductoAdd()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }
        void Actualizar()
        {
            mp.Mostrar(dataGridView1, txtBuscar.Text);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.IdProducto = int.Parse(dataGridView1.Rows[fila].
               Cells[0].Value.ToString());
           producto.Nombre = dataGridView1.Rows[fila].
                Cells[1].Value.ToString();
            producto.Descripcion = dataGridView1.Rows[fila].
               Cells[2].Value.ToString();
            producto.Precio= dataGridView1.Rows[fila].
               Cells[3].Value.ToString();

            switch (col)
            {
                case 4:
                    {
                        FrmProductos fp = new FrmProductos();
                        fp.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        mp.Borrar(producto);
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.IdProducto = -1;
            FrmProductos fp = new FrmProductos();
            fp.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
