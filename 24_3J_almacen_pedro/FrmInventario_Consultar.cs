using System.Data;

namespace _24_3J_almacen_pedro
{
    public partial class FrmInventario_Consultar : Form
    {
        public FrmInventario_Consultar()
        {
            InitializeComponent();
        }
        private void LimpiarGrilla()
        {
            while (dgwRegistros.Rows.Count > 0)
            {
                dgwRegistros.Rows.RemoveAt(0);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConectorAlmacen conectorAlmacen = new ConectorAlmacen();
            DataTable dt = new DataTable();

            this.LimpiarGrilla();

            dt = conectorAlmacen.ConsultaTodos();

            dgwRegistros.DataSource = dt;

        }

    }
}
