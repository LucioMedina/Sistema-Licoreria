namespace DESIGNER.Mantenimieto
{
    partial class FormEmpleado
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtidperso = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbeditar = new System.Windows.Forms.RadioButton();
            this.rbeliminar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Empleados Registradas";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(85, 54);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(113, 31);
            this.txtidempleado.TabIndex = 6;
            this.txtidempleado.Visible = false;
            // 
            // dgvempleados
            // 
            this.dgvempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(311, 76);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(905, 522);
            this.dgvempleados.TabIndex = 5;
            this.dgvempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbeliminar);
            this.groupBox1.Controls.Add(this.txtidempleado);
            this.groupBox1.Controls.Add(this.rbeditar);
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txtidperso);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 522);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsalir.Location = new System.Drawing.Point(11, 477);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(231, 39);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(9, 339);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(233, 38);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(9, 185);
            this.txtclave.MaxLength = 8;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(233, 27);
            this.txtclave.TabIndex = 6;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(9, 383);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(233, 38);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(9, 130);
            this.txtusuario.MaxLength = 30;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(233, 27);
            this.txtusuario.TabIndex = 5;
            // 
            // txtidperso
            // 
            this.txtidperso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidperso.Location = new System.Drawing.Point(9, 75);
            this.txtidperso.MaxLength = 30;
            this.txtidperso.Name = "txtidperso";
            this.txtidperso.Size = new System.Drawing.Size(233, 27);
            this.txtidperso.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(9, 297);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(233, 36);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Persona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // rbeditar
            // 
            this.rbeditar.AutoSize = true;
            this.rbeditar.Location = new System.Drawing.Point(6, 235);
            this.rbeditar.Name = "rbeditar";
            this.rbeditar.Size = new System.Drawing.Size(79, 29);
            this.rbeditar.TabIndex = 12;
            this.rbeditar.Text = "Editar";
            this.rbeditar.UseVisualStyleBackColor = true;
            this.rbeditar.CheckedChanged += new System.EventHandler(this.rbeditar_CheckedChanged);
            // 
            // rbeliminar
            // 
            this.rbeliminar.AutoSize = true;
            this.rbeliminar.Location = new System.Drawing.Point(146, 235);
            this.rbeliminar.Name = "rbeliminar";
            this.rbeliminar.Size = new System.Drawing.Size(96, 29);
            this.rbeliminar.TabIndex = 14;
            this.rbeliminar.Text = "Eliminar";
            this.rbeliminar.UseVisualStyleBackColor = true;
            this.rbeliminar.CheckedChanged += new System.EventHandler(this.rbeliminar_CheckedChanged);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 622);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtidperso;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbeditar;
        private System.Windows.Forms.RadioButton rbeliminar;
    }
}