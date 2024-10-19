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
    public partial class FrmAlmacenConsultar2 : Form
    {
        public FrmAlmacenConsultar2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            ConectorAlmacen conectorAlmacen = new ConectorAlmacen();
            DataTable dt = new DataTable();

            dt = conectorAlmacen.ConsultaTodos();

            dgvAlmacen.DataSource = dt;

        }


    }
}
