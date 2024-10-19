using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using Microsoft.VisualBasic;

// agregar la librería SpreadsheetLight, desde NuGet
// https://spreadsheetlight.com/sample-code/

namespace _24_3J_almacen_pedro
{
    public partial class frmInventario_Guardar : Form
    {
        public frmInventario_Guardar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            Almacen almacen = new Almacen(2, "jabón", "Jabón ariel", 7, 0, 0, 7);

            txtCodigo.Text = Convert.ToString(almacen.Codigo);
            txtProducto.Text = almacen.Producto;
            txtDescripcion.Text = almacen.Descripcion;
            txtStockInicial.Text = Convert.ToString(almacen.StockInicial);
            txtEntradas.Text = Convert.ToString(almacen.Entradas);
            txtSalidas.Text = Convert.ToString(almacen.Salidas);
            txtTotal.Text = Convert.ToString(almacen.Total);

        }

        private void btnCrearExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SpreadsheetLight.SLDocument oDocumento = new SpreadsheetLight.SLDocument();

            String rutaArchivo;
            //rutaArchivo = "C:\Users\pedro\Proyectos\archivo.xlsx";
            rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "archivo.xlsx";

            // columnas
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Edad", typeof(int));
            dt.Columns.Add("Sexo", typeof(string));

            //renglones
            dt.Rows.Add("Juan", 18, "Hombre");
            dt.Rows.Add("Ana", 21, "Mujer");

            oDocumento.ImportDataTable(1, 1, dt, true);

            oDocumento.SaveAs(rutaArchivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLDocument oDoc = new SLDocument("almacen.xlsx");
            // Selecionar la hoja
            oDoc.SelectWorksheet("inventario");
            //escribir en una celda
            oDoc.SetCellValue("A3", "INVENTARIO");

            // Selecionar la hoja
            oDoc.SelectWorksheet("entradas");
            //escribir en una celda
            oDoc.SetCellValue("A3", "ENTRADAS");
            // Selecionar la hoja
            oDoc.SelectWorksheet("salidas");
            //escribir en una celda
            oDoc.SetCellValue("A3", "SALIDAS");

            oDoc.SaveAs("almacen.xlsx");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Almacen almacen = new Almacen();
                int posicion = 0;
                ConectorAlmacen conector = new ConectorAlmacen();

                almacen.Codigo = Convert.ToInt32(txtCodigo.Text);
                almacen.Producto = txtProducto.Text;
                almacen.Descripcion = txtDescripcion.Text;
                almacen.StockInicial = Convert.ToSingle(txtStockInicial.Text);
                almacen.Entradas = Convert.ToSingle(txtEntradas.Text);
                almacen.Salidas = Convert.ToSingle(txtSalidas.Text);
                almacen.Total = Convert.ToSingle(txtTotal.Text);

                posicion = conector.Grabar(almacen);

                MessageBox.Show("Almacenado");

            }
            catch (Exception errorProceso)
            {
                MessageBox.Show("Error" + errorProceso.Message);
            }

        }





    }
}
