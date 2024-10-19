namespace _24_3J_almacen_pedro
{
    partial class FrmAlmacenConsultar2
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
            btnConsultar = new Button();
            dgvAlmacen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacen).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 12);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvAlmacen
            // 
            dgvAlmacen.AllowUserToAddRows = false;
            dgvAlmacen.AllowUserToDeleteRows = false;
            dgvAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlmacen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlmacen.Location = new Point(12, 51);
            dgvAlmacen.Name = "dgvAlmacen";
            dgvAlmacen.Size = new Size(776, 299);
            dgvAlmacen.TabIndex = 1;
            // 
            // FrmAlmacenConsultar2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAlmacen);
            Controls.Add(btnConsultar);
            Name = "FrmAlmacenConsultar2";
            Text = "FrmAlmacenConsultar2";
            ((System.ComponentModel.ISupportInitialize)dgvAlmacen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsultar;
        private DataGridView dgvAlmacen;
    }
}