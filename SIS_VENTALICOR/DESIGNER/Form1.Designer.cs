namespace DESIGNER
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncompras = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncompras
            // 
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.Image = global::DESIGNER.Properties.Resources.bolsa_de_la_compra;
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncompras.Location = new System.Drawing.Point(295, 284);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(230, 179);
            this.btncompras.TabIndex = 1;
            this.btncompras.Text = "Compras";
            this.btncompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.Image = global::DESIGNER.Properties.Resources.analitica;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreporte.Location = new System.Drawing.Point(295, 58);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(230, 179);
            this.btnreporte.TabIndex = 1;
            this.btnreporte.Text = "Reportes";
            this.btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreporte.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = global::DESIGNER.Properties.Resources.metodo_de_pago;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(585, 58);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(230, 179);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Image = global::DESIGNER.Properties.Resources.agregar_usuario;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleado.Location = new System.Drawing.Point(46, 284);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(230, 179);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.Image = global::DESIGNER.Properties.Resources.grupo;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonas.Location = new System.Drawing.Point(46, 58);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(230, 179);
            this.btnPersonas.TabIndex = 0;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 553);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnreporte;
    }
}

