using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;


namespace _24_3J_almacen_pedro
{
    class ConectorAlmacen
    {
        // atributos
        private string ArchivoNombre = "almacen.xlsx";

        private string HojaNombre = "inventario";

        //constructor
        public ConectorAlmacen() { }

        //métodos
        public int Grabar(Almacen almacen) {

            int renglonDisponible = 0;
            renglonDisponible = this.BuscarRenglonDisponible();
            this.Escribir(almacen, renglonDisponible);
            return renglonDisponible;
        }

        private int BuscarRenglonDisponible() {
            SLDocument oDoc = new SLDocument(this.ArchivoNombre);
            int renglon = 2;
            // Selecionar la hoja
            oDoc.SelectWorksheet(this.HojaNombre);
            while (oDoc.GetCellValueAsString(renglon, 1) != "" ) {
                renglon++;
            }
            return renglon;
        }

        public void Escribir(Almacen almacen, int renglonDisponible) {
            SLDocument oDoc = new SLDocument(this.ArchivoNombre);
            // Selecionar la hoja
            oDoc.SelectWorksheet(this.HojaNombre);
            //escribir el almacen
            oDoc.SetCellValue(renglonDisponible, 1, almacen.Codigo);
            oDoc.SetCellValue(renglonDisponible, 2, almacen.Producto);
            oDoc.SetCellValue(renglonDisponible, 3, almacen.Descripcion);
            oDoc.SetCellValue(renglonDisponible, 4, almacen.StockInicial);
            oDoc.SetCellValue(renglonDisponible, 5, almacen.Entradas);
            oDoc.SetCellValue(renglonDisponible, 6, almacen.Salidas);
            oDoc.SetCellValue(renglonDisponible, 7, almacen.Total);
            //Guardar archivo
            oDoc.SaveAs(this.ArchivoNombre);
        }
        public DataTable ConsultaTodos() { 
            DataTable dt = new DataTable();

            dt.Columns.Add("Código", typeof(int));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Stock", typeof(float));
            dt.Columns.Add("Entradas", typeof(float));
            dt.Columns.Add("Salidas", typeof(float));
            dt.Columns.Add("Total", typeof(float));
    //
            SLDocument oDoc = new SLDocument(this.ArchivoNombre);
            SLWorksheetStatistics stats = new SLWorksheetStatistics();
            int renglon = 0;
            int columna = 0;
            // Selecionar la hoja
            oDoc.SelectWorksheet(this.HojaNombre);
            stats = oDoc.GetWorksheetStatistics();
            columna = stats.StartColumnIndex;


            //for (renglon = stats.StartRowIndex + 1; renglon < stats.EndRowIndex; renglon++) {
              
            for (renglon = stats.StartRowIndex +1; oDoc.GetCellValueAsInt64(renglon, columna)>0; renglon++) { 
                dt.Rows.Add(oDoc.GetCellValueAsInt64(renglon, columna),
                    oDoc.GetCellValueAsString(renglon, columna + 1),
                    oDoc.GetCellValueAsString(renglon, columna + 2),
                    oDoc.GetCellValueAsDouble(renglon, columna + 3),
                    oDoc.GetCellValueAsDouble(renglon, columna + 4),
                    oDoc.GetCellValueAsDouble(renglon, columna + 5),
                    oDoc.GetCellValueAsDouble(renglon, columna + 6)     );
            }
            return dt; 
        }


        public Almacen BuscarPorCodigo(int codigo)
        {
            SLDocument oDoc = new SLDocument(this.ArchivoNombre);
            Almacen registro = new Almacen();
            int renglon = 2;

            // Selecionar la hoja
            oDoc.SelectWorksheet(this.HojaNombre);
            while (oDoc.GetCellValueAsString(renglon, 1) != "" &&
                oDoc.GetCellValueAsInt32(renglon, 1) != codigo )
            {
                renglon++;                
            }
            // verificar la condición de salida
            if (oDoc.GetCellValueAsInt32(renglon, 1) == codigo) {
                registro.PosicionExcel = renglon;
                registro.Codigo = oDoc.GetCellValueAsInt32(renglon, 1);
                registro.Producto = oDoc.GetCellValueAsString(renglon, 2);
                registro.Descripcion = oDoc.GetCellValueAsString(renglon, 3);
                registro.StockInicial = (float) oDoc.GetCellValueAsDouble(renglon, 4);
                registro.Entradas = (float) oDoc.GetCellValueAsDouble(renglon, 5);
                registro.Salidas = (float) oDoc.GetCellValueAsDouble(renglon, 6);
                registro.Total = (float) oDoc.GetCellValueAsDouble(renglon, 7);
            }
            return registro;
        }

        public void Borrar( int renglon)
        {
            SLDocument oDoc = new SLDocument(this.ArchivoNombre);
            // Selecionar la hoja
            oDoc.SelectWorksheet(this.HojaNombre);
            //escribir el almacen
            oDoc.DeleteRow(renglon, 1);
            //Guardar archivo
            oDoc.SaveAs(this.ArchivoNombre);
        }

    }
}
