﻿namespace _24_3J_almacen_pedro
{
    partial class FrmInventario_Actualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnActualizar = new Button();
            btnBuscar = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtSalidas = new TextBox();
            lblSalidas = new Label();
            txtEntradas = new TextBox();
            lblEntradas = new Label();
            txtStockInicial = new TextBox();
            lblStockInicial = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtProducto = new TextBox();
            lblProducto = new Label();
            txtCodigo = new TextBox();
            lbl = new Label();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(451, 159);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 65);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(451, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 53);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(178, 306);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(228, 43);
            txtTotal.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(17, 312);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 37);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total";
            // 
            // txtSalidas
            // 
            txtSalidas.Location = new Point(178, 257);
            txtSalidas.Name = "txtSalidas";
            txtSalidas.Size = new Size(228, 43);
            txtSalidas.TabIndex = 29;
            // 
            // lblSalidas
            // 
            lblSalidas.AutoSize = true;
            lblSalidas.Location = new Point(17, 263);
            lblSalidas.Name = "lblSalidas";
            lblSalidas.Size = new Size(100, 37);
            lblSalidas.TabIndex = 28;
            lblSalidas.Text = "Salidas";
            // 
            // txtEntradas
            // 
            txtEntradas.Location = new Point(178, 208);
            txtEntradas.Name = "txtEntradas";
            txtEntradas.Size = new Size(228, 43);
            txtEntradas.TabIndex = 27;
            // 
            // lblEntradas
            // 
            lblEntradas.AutoSize = true;
            lblEntradas.Location = new Point(17, 214);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(119, 37);
            lblEntradas.TabIndex = 26;
            lblEntradas.Text = "Entradas";
            // 
            // txtStockInicial
            // 
            txtStockInicial.Location = new Point(178, 159);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(228, 43);
            txtStockInicial.TabIndex = 25;
            // 
            // lblStockInicial
            // 
            lblStockInicial.AutoSize = true;
            lblStockInicial.Location = new Point(17, 165);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(156, 37);
            lblStockInicial.TabIndex = 24;
            lblStockInicial.Text = "Stock Inicial";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(178, 110);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 43);
            txtDescripcion.TabIndex = 23;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(17, 116);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(155, 37);
            lblDescripcion.TabIndex = 22;
            lblDescripcion.Text = "Descripción";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(178, 61);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(228, 43);
            txtProducto.TabIndex = 21;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(17, 67);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(125, 37);
            lblProducto.TabIndex = 20;
            lblProducto.Text = "Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(178, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(228, 43);
            txtCodigo.TabIndex = 19;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(17, 18);
            lbl.Name = "lbl";
            lbl.Size = new Size(105, 37);
            lbl.TabIndex = 18;
            lbl.Text = "Código";
            // 
            // FrmInventario_Actualizar
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 433);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
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
            Name = "FrmInventario_Actualizar";
            Text = "FrmInventario_Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnBuscar;
        private TextBox txtTotal;
        private Label lblTotal;
        private TextBox txtSalidas;
        private Label lblSalidas;
        private TextBox txtEntradas;
        private Label lblEntradas;
        private TextBox txtStockInicial;
        private Label lblStockInicial;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtProducto;
        private Label lblProducto;
        private TextBox txtCodigo;
        private Label lbl;
    }
}