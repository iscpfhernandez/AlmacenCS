namespace _24_3J_almacen_pedro
{
    partial class FrmInventario_Consultar
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtProducto = new TextBox();
            lblProducto = new Label();
            lblStockInicial = new Label();
            txtStockInicial = new TextBox();
            cmbStockInicial = new ComboBox();
            cmbEntradas = new ComboBox();
            txtEntradas = new TextBox();
            lblEntradas = new Label();
            cmbSalidas = new ComboBox();
            txtSalidas = new TextBox();
            lblSalidas = new Label();
            cmbTotal = new ComboBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            dgwRegistros = new DataGridView();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwRegistros).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(105, 37);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(139, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(310, 43);
            txtCodigo.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(139, 60);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(310, 43);
            txtProducto.TabIndex = 3;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 63);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(125, 37);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblStockInicial
            // 
            lblStockInicial.AutoSize = true;
            lblStockInicial.Location = new Point(12, 107);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(156, 37);
            lblStockInicial.TabIndex = 4;
            lblStockInicial.Text = "Stock Inicial";
            // 
            // txtStockInicial
            // 
            txtStockInicial.Location = new Point(349, 109);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(100, 43);
            txtStockInicial.TabIndex = 5;
            // 
            // cmbStockInicial
            // 
            cmbStockInicial.FormattingEnabled = true;
            cmbStockInicial.Location = new Point(139, 107);
            cmbStockInicial.Name = "cmbStockInicial";
            cmbStockInicial.Size = new Size(204, 45);
            cmbStockInicial.TabIndex = 6;
            //cmbStockInicial.SelectedIndexChanged += cmbStockInicial_SelectedIndexChanged;
            // 
            // cmbEntradas
            // 
            cmbEntradas.FormattingEnabled = true;
            cmbEntradas.Location = new Point(139, 158);
            cmbEntradas.Name = "cmbEntradas";
            cmbEntradas.Size = new Size(204, 45);
            cmbEntradas.TabIndex = 9;
            // 
            // txtEntradas
            // 
            txtEntradas.Location = new Point(349, 160);
            txtEntradas.Name = "txtEntradas";
            txtEntradas.Size = new Size(100, 43);
            txtEntradas.TabIndex = 8;
            // 
            // lblEntradas
            // 
            lblEntradas.AutoSize = true;
            lblEntradas.Location = new Point(12, 158);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(119, 37);
            lblEntradas.TabIndex = 7;
            lblEntradas.Text = "Entradas";
            // 
            // cmbSalidas
            // 
            cmbSalidas.FormattingEnabled = true;
            cmbSalidas.Location = new Point(139, 209);
            cmbSalidas.Name = "cmbSalidas";
            cmbSalidas.Size = new Size(204, 45);
            cmbSalidas.TabIndex = 12;
            // 
            // txtSalidas
            // 
            txtSalidas.Location = new Point(349, 211);
            txtSalidas.Name = "txtSalidas";
            txtSalidas.Size = new Size(100, 43);
            txtSalidas.TabIndex = 11;
            // 
            // lblSalidas
            // 
            lblSalidas.AutoSize = true;
            lblSalidas.Location = new Point(12, 209);
            lblSalidas.Name = "lblSalidas";
            lblSalidas.Size = new Size(100, 37);
            lblSalidas.TabIndex = 10;
            lblSalidas.Text = "Salidas";
            // 
            // cmbTotal
            // 
            cmbTotal.FormattingEnabled = true;
            cmbTotal.Location = new Point(139, 260);
            cmbTotal.Name = "cmbTotal";
            cmbTotal.Size = new Size(204, 45);
            cmbTotal.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(349, 262);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 43);
            txtTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 260);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 37);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // dgwRegistros
            // 
            dgwRegistros.AllowUserToAddRows = false;
            dgwRegistros.AllowUserToDeleteRows = false;
            dgwRegistros.AllowUserToOrderColumns = true;
            dgwRegistros.AllowUserToResizeColumns = false;
            dgwRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRegistros.Location = new Point(12, 311);
            dgwRegistros.Name = "dgwRegistros";
            dgwRegistros.Size = new Size(784, 192);
            dgwRegistros.TabIndex = 16;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(488, 60);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(207, 58);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FrmInventario_Consultar
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 530);
            Controls.Add(btnConsultar);
            Controls.Add(dgwRegistros);
            Controls.Add(cmbTotal);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(cmbSalidas);
            Controls.Add(txtSalidas);
            Controls.Add(lblSalidas);
            Controls.Add(cmbEntradas);
            Controls.Add(txtEntradas);
            Controls.Add(lblEntradas);
            Controls.Add(cmbStockInicial);
            Controls.Add(txtStockInicial);
            Controls.Add(lblStockInicial);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FrmInventario_Consultar";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtProducto;
        private Label lblProducto;
        private Label lblStockInicial;
        private TextBox txtStockInicial;
        private ComboBox cmbStockInicial;
        private ComboBox cmbEntradas;
        private TextBox txtEntradas;
        private Label lblEntradas;
        private ComboBox cmbSalidas;
        private TextBox txtSalidas;
        private Label lblSalidas;
        private ComboBox cmbTotal;
        private TextBox txtTotal;
        private Label lblTotal;
        private DataGridView dgwRegistros;
        private Button btnConsultar;
    }
}
