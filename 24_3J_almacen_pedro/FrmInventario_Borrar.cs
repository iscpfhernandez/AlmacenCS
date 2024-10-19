using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_3J_almacen_pedro
{
    public partial class FrmInventario_Borrar : Form
    {
        public FrmInventario_Borrar()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtStockInicial.Text = string.Empty;
            txtEntradas.Text = string.Empty;
            txtSalidas.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscar = 0;
            buscar = Convert.ToInt32(txtCodigo.Text);
            ConectorAlmacen conector = new ConectorAlmacen();
            Almacen registro = new Almacen();
            this.Limpiar();
            registro = conector.BuscarPorCodigo(buscar);

            if (registro.PosicionExcel > 0)
            {
                txtProducto.Text = registro.Producto;
                txtDescripcion.Text = registro.Descripcion;
                txtStockInicial.Text = Convert.ToString(registro.StockInicial);
                txtEntradas.Text = Convert.ToString(registro.Entradas);
                txtSalidas.Text = Convert.ToString(registro.Salidas);
                txtTotal.Text = Convert.ToString(registro.Total);
            }
            else
            {
                MessageBox.Show("Código no encontrado.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int buscar = 0;
            buscar = Convert.ToInt32(txtCodigo.Text);
            ConectorAlmacen conector = new ConectorAlmacen();
            Almacen registro = new Almacen();
            registro = conector.BuscarPorCodigo(buscar);

            if (registro.PosicionExcel > 0)
            {
                conector.Borrar(registro.PosicionExcel);
                this.Limpiar();
                txtCodigo.Text = string.Empty;
                MessageBox.Show("Registro eliminado.");
            }
            else
            {
                MessageBox.Show("Código no encontrado.");
            }
        }
    }
}
