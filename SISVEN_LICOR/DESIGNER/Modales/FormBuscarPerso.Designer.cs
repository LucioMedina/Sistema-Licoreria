namespace DESIGNER.Modales
{
    partial class FormBuscarPerso
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscadorCliente = new System.Windows.Forms.TextBox();
            this.btnReiniciarBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dbeditar = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 604);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscadorCliente);
            this.tabPage1.Controls.Add(this.btnReiniciarBusqueda);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gridClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda de clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorCliente
            // 
            this.txtBuscadorCliente.Location = new System.Drawing.Point(211, 23);
            this.txtBuscadorCliente.Name = "txtBuscadorCliente";
            this.txtBuscadorCliente.Size = new System.Drawing.Size(418, 20);
            this.txtBuscadorCliente.TabIndex = 1;
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
            this.label3.Location = new System.Drawing.Point(208, 58);
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
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el apellido del cliente:";
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(13, 79);
            this.gridClientes.MultiSelect = false;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(790, 484);
            this.gridClientes.TabIndex = 5;
            this.gridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellDoubleClick);
            this.gridClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridClientes_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvpersonas);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro de clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.AllowUserToAddRows = false;
            this.dgvpersonas.AllowUserToDeleteRows = false;
            this.dgvpersonas.AllowUserToResizeRows = false;
            this.dgvpersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpersonas.BackgroundColor = System.Drawing.Color.White;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Location = new System.Drawing.Point(31, 125);
            this.dgvpersonas.MultiSelect = false;
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.ReadOnly = true;
            this.dgvpersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpersonas.Size = new System.Drawing.Size(754, 421);
            this.dgvpersonas.TabIndex = 6;
            this.dgvpersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonas_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbeditar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(147, 32);
            this.txtnombres.MaxLength = 30;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(122, 20);
            this.txtnombres.TabIndex = 1;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(540, 29);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(284, 32);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(114, 20);
            this.txtdni.TabIndex = 1;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(445, 29);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Registrar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(9, 32);
            this.txtapellidos.MaxLength = 30;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(120, 20);
            this.txtapellidos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellidos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(751, 618);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 27);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // dbeditar
            // 
            this.dbeditar.AutoSize = true;
            this.dbeditar.Location = new System.Drawing.Point(696, 58);
            this.dbeditar.Name = "dbeditar";
            this.dbeditar.Size = new System.Drawing.Size(52, 17);
            this.dbeditar.TabIndex = 9;
            this.dbeditar.TabStop = true;
            this.dbeditar.Text = "Editar";
            this.dbeditar.UseVisualStyleBackColor = true;
            this.dbeditar.CheckedChanged += new System.EventHandler(this.dbeditar_CheckedChanged);
            // 
            // FormBuscarPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormBuscarPerso";
            this.Text = "FormBuscarPerso";
            this.Load += new System.EventHandler(this.FormBuscarPerso_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txtBuscadorCliente;
        private System.Windows.Forms.Button btnReiniciarBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton dbeditar;
    }
}