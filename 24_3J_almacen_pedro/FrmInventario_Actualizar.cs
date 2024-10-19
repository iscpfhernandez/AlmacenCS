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
    public partial class FrmInventario_Actualizar : Form
    {
        public FrmInventario_Actualizar()
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int buscar = 0;
            buscar = Convert.ToInt32(txtCodigo.Text);
            ConectorAlmacen conector = new ConectorAlmacen();
            Almacen registro = new Almacen();
            // this.Limpiar();
            registro = conector.BuscarPorCodigo(buscar);

            if (registro.PosicionExcel > 0)
            {
                registro.Producto = txtProducto.Text;
                registro.Descripcion = txtDescripcion.Text;
                registro.StockInicial = Convert.ToSingle(txtStockInicial.Text);
                registro.Entradas = Convert.ToSingle(txtEntradas.Text);
                registro.Salidas = Convert.ToSingle(txtSalidas.Text);
                registro.Total = Convert.ToSingle(txtTotal.Text);
                conector.Escribir(registro, registro.PosicionExcel);
                MessageBox.Show("Registro actualizado.");
            }
            else {
                MessageBox.Show("Registro no encontrado.");
            }
        }
    }
}
