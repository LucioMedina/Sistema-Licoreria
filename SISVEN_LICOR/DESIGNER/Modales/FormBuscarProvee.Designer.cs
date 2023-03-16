namespace DESIGNER.Modales
{
    partial class FormBuscarProvee
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
            this.txtBuscadorprovee = new System.Windows.Forms.TextBox();
            this.btnReiniciarBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(751, 610);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 27);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(39, -6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 604);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscadorprovee);
            this.tabPage1.Controls.Add(this.btnReiniciarBusqueda);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gridProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda de productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorprovee
            // 
            this.txtBuscadorprovee.Location = new System.Drawing.Point(98, 32);
            this.txtBuscadorprovee.Name = "txtBuscadorprovee";
            this.txtBuscadorprovee.Size = new System.Drawing.Size(418, 20);
            this.txtBuscadorprovee.TabIndex = 1;
            this.txtBuscadorprovee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscadorprovee_KeyUp);
            // 
            // btnReiniciarBusqueda
            // 
            this.btnReiniciarBusqueda.Location = new System.Drawing.Point(548, 32);
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
            this.label3.Location = new System.Drawing.Point(119, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pulse doble clic sobre el registro para enviarlo a la venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores:";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToResizeRows = false;
            this.gridProductos.BackgroundColor = System.Drawing.Color.White;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(13, 79);
            this.gridProductos.MultiSelect = false;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(790, 484);
            this.gridProductos.TabIndex = 5;
            // 
            // FormBuscarProvee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 631);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBuscarProvee";
            this.Text = "FormBuscarProvee";
            this.Load += new System.EventHandler(this.FormBuscarProvee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtBuscadorprovee;
        private System.Windows.Forms.Button btnReiniciarBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProductos;
    }
}