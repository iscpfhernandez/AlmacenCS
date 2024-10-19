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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario_Guardar form = new frmInventario_Guardar();
            form.MdiParent = this;
            form.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FrmInventario_Consultar form = new FrmInventario_Consultar();

            FrmAlmacenConsultar2 form = new FrmAlmacenConsultar2();
            form.MdiParent = this;
            form.Show();

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario_Actualizar form = new FrmInventario_Actualizar();
            form.MdiParent = this;
            form.Show();

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario_Borrar form = new FrmInventario_Borrar();
            form.MdiParent = this;
            form.Show();
        }
    }
}
