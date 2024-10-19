using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_3J_almacen_pedro
{
    internal class Almacen
    {
        public int PosicionExcel { get; set; }
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public float StockInicial { get; set; }
        public float Entradas { get; set; }
        public float Salidas {  get; set; }
        public float Total {  get; set; }
   

        // constructor
        public Almacen(int codigo, string producto, string descripcion, float stockInicial, float entrada, float salidas, float total)
        {
            this.Codigo = codigo;  
            this.Producto = producto;   
            this.Descripcion = descripcion;
            this.StockInicial = stockInicial;
            this.Entradas = entrada;
            this.Salidas = salidas;
            this.Total = total;
        }
        public Almacen()
        {
            this.PosicionExcel = 0;

            Producto = string.Empty;
            Descripcion = string.Empty;
        }


    }
}
