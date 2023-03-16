namespace DESIGNER.Modales
{
    partial class FormbuscarProduc
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscadorProducto = new System.Windows.Forms.TextBox();
            this.btnReiniciarBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvprovee = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(791, 618);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 27);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(79, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 604);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscadorProducto);
            this.tabPage1.Controls.Add(this.btnReiniciarBusqueda);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvprovee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda de productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorProducto
            // 
            this.txtBuscadorProducto.Location = new System.Drawing.Point(211, 23);
            this.txtBuscadorProducto.Name = "txtBuscadorProducto";
            this.txtBuscadorProducto.Size = new System.Drawing.Size(418, 20);
            this.txtBuscadorProducto.TabIndex = 1;
            this.txtBuscadorProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscadorProducto_KeyUp);
            // 
            // btnReiniciarBusqueda
            // 
            this.btnReiniciarBusqueda.Location = new System.Drawing.Point(635, 21);
            this.btnReiniciarBusqueda.Name = "btnReiniciarBusqueda";
            this.btnReiniciarBusqueda.Size = new System.Drawing.Size(168, 27);
            this.btnReiniciarBusqueda.TabIndex = 3;
            this.btnReiniciarBusqueda.Text = "Reiniciar búsqueda";
            this.btnReiniciarBusqueda.UseVisualStyleBackColor = true;
            this.btnReiniciarBusqueda.Click += new System.EventHandler(this.btnReiniciarBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pulse doble clic sobre el registro para enviarlo a la venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba nombre del producto:";
            // 
            // dgvprovee
            // 
            this.dgvprovee.AllowUserToAddRows = false;
            this.dgvprovee.AllowUserToDeleteRows = false;
            this.dgvprovee.AllowUserToResizeRows = false;
            this.dgvprovee.BackgroundColor = System.Drawing.Color.White;
            this.dgvprovee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprovee.Location = new System.Drawing.Point(13, 79);
            this.dgvprovee.MultiSelect = false;
            this.dgvprovee.Name = "dgvprovee";
            this.dgvprovee.ReadOnly = true;
            this.dgvprovee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprovee.Size = new System.Drawing.Size(790, 484);
            this.dgvprovee.TabIndex = 5;
            this.dgvprovee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellDoubleClick);
            // 
            // FormbuscarProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 659);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormbuscarProduc";
            this.Text = "FormbuscarProduc";
            this.Load += new System.EventHandler(this.FormbuscarProduc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprovee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtBuscadorProducto;
        private System.Windows.Forms.Button btnReiniciarBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvprovee;
    }
}