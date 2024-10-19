namespace _24_3J_almacen_pedro
{
    partial class frmInventario_Guardar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            txtCodigo = new TextBox();
            txtProducto = new TextBox();
            lblProducto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtSalidas = new TextBox();
            lblSalidas = new Label();
            txtEntradas = new TextBox();
            lblEntradas = new Label();
            txtStockInicial = new TextBox();
            lblStockInicial = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnMostrar = new Button();
            btnCrearExcel = new Button();
            button1 = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(-1, 18);
            lbl.Name = "lbl";
            lbl.Size = new Size(105, 37);
            lbl.TabIndex = 0;
            lbl.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(160, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(228, 43);
            txtCodigo.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(160, 61);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(228, 43);
            txtProducto.TabIndex = 3;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(-1, 67);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(125, 37);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(160, 110);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 43);
            txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(-1, 116);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(155, 37);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // txtSalidas
            // 
            txtSalidas.Location = new Point(160, 257);
            txtSalidas.Name = "txtSalidas";
            txtSalidas.Size = new Size(228, 43);
            txtSalidas.TabIndex = 11;
            // 
            // lblSalidas
            // 
            lblSalidas.AutoSize = true;
            lblSalidas.Location = new Point(-1, 263);
            lblSalidas.Name = "lblSalidas";
            lblSalidas.Size = new Size(100, 37);
            lblSalidas.TabIndex = 10;
            lblSalidas.Text = "Salidas";
            // 
            // txtEntradas
            // 
            txtEntradas.Location = new Point(160, 208);
            txtEntradas.Name = "txtEntradas";
            txtEntradas.Size = new Size(228, 43);
            txtEntradas.TabIndex = 9;
            // 
            // lblEntradas
            // 
            lblEntradas.AutoSize = true;
            lblEntradas.Location = new Point(-1, 214);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(119, 37);
            lblEntradas.TabIndex = 8;
            lblEntradas.Text = "Entradas";
            // 
            // txtStockInicial
            // 
            txtStockInicial.Location = new Point(160, 159);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(228, 43);
            txtStockInicial.TabIndex = 7;
            // 
            // lblStockInicial
            // 
            lblStockInicial.AutoSize = true;
            lblStockInicial.Location = new Point(-1, 165);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(156, 37);
            lblStockInicial.TabIndex = 6;
            lblStockInicial.Text = "Stock Inicial";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(160, 306);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(228, 43);
            txtTotal.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(-1, 312);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 37);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(433, 18);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(119, 53);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnCrearExcel
            // 
            btnCrearExcel.Location = new Point(433, 67);
            btnCrearExcel.Name = "btnCrearExcel";
            btnCrearExcel.Size = new Size(119, 53);
            btnCrearExcel.TabIndex = 15;
            btnCrearExcel.Text = "Crear Excel";
            btnCrearExcel.UseVisualStyleBackColor = true;
            btnCrearExcel.Click += btnCrearExcel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(418, 208);
            button1.Name = "button1";
            button1.Size = new Size(150, 122);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(433, 130);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 60);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmInventario_Guardar
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 405);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(btnCrearExcel);
            Controls.Add(btnMostrar);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtSalidas);
            Controls.Add(lblSalidas);
            Controls.Add(txtEntradas);
            Controls.Add(lblEntradas);
            Controls.Add(txtStockInicial);
            Controls.Add(lblStockInicial);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(txtCodigo);
            Controls.Add(lbl);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "frmInventario_Guardar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtCodigo;
        private TextBox txtProducto;
        private Label lblProducto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtSalidas;
        private Label lblSalidas;
        private TextBox txtEntradas;
        private Label lblEntradas;
        private TextBox txtStockInicial;
        private Label lblStockInicial;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnMostrar;
        private Button btnCrearExcel;
        private Button button1;
        private Button btnGuardar;
    }
}
