namespace DESIGNER
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnagregarprod = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvventas = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscarproduc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnomproduc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigoproduc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscarpersonas = new System.Windows.Forms.Button();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.optDeposito = new System.Windows.Forms.RadioButton();
            this.optVisa = new System.Windows.Forms.RadioButton();
            this.optPlin = new System.Windows.Forms.RadioButton();
            this.optYape = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(509, 35);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(74, 32);
            this.txtsubtotal.TabIndex = 27;
            // 
            // txtigv
            // 
            this.txtigv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigv.Location = new System.Drawing.Point(641, 35);
            this.txtigv.Multiline = true;
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(86, 34);
            this.txtigv.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(397, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Subtotal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(589, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "IGV:";
            // 
            // txtletras
            // 
            this.txtletras.Enabled = false;
            this.txtletras.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletras.Location = new System.Drawing.Point(431, 557);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.ReadOnly = true;
            this.txtletras.Size = new System.Drawing.Size(707, 35);
            this.txtletras.TabIndex = 23;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnsalir.Location = new System.Drawing.Point(1171, 11);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(73, 31);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnventa
            // 
            this.btnventa.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Location = new System.Drawing.Point(1171, 156);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(97, 58);
            this.btnventa.TabIndex = 21;
            this.btnventa.Text = "Venta";
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnagregarprod
            // 
            this.btnagregarprod.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarprod.Location = new System.Drawing.Point(1171, 83);
            this.btnagregarprod.Name = "btnagregarprod";
            this.btnagregarprod.Size = new System.Drawing.Size(97, 58);
            this.btnagregarprod.TabIndex = 20;
            this.btnagregarprod.Text = "Agregar";
            this.btnagregarprod.UseVisualStyleBackColor = true;
            this.btnagregarprod.Click += new System.EventHandler(this.btnagregarprod_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(826, 32);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(97, 35);
            this.txttotal.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(739, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 35);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total:";
            // 
            // dgvventas
            // 
            this.dgvventas.AllowUserToOrderColumns = true;
            this.dgvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colIdProducto,
            this.colDescripcion,
            this.colPrecio,
            this.colImporte});
            this.dgvventas.EnableHeadersVisualStyles = false;
            this.dgvventas.Location = new System.Drawing.Point(44, 223);
            this.dgvventas.Name = "dgvventas";
            this.dgvventas.Size = new System.Drawing.Size(1094, 249);
            this.dgvventas.TabIndex = 17;
            this.dgvventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventas_CellClick);
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colImporte
            // 
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbuscarproduc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtnomproduc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtcodigoproduc);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1100, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info. Producto";
            // 
            // btnbuscarproduc
            // 
            this.btnbuscarproduc.Location = new System.Drawing.Point(387, 55);
            this.btnbuscarproduc.Name = "btnbuscarproduc";
            this.btnbuscarproduc.Size = new System.Drawing.Size(75, 30);
            this.btnbuscarproduc.TabIndex = 10;
            this.btnbuscarproduc.Text = "Buscar";
            this.btnbuscarproduc.UseVisualStyleBackColor = true;
            this.btnbuscarproduc.Click += new System.EventHandler(this.btnbuscarproduc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(949, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(953, 55);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 29);
            this.txtcantidad.TabIndex = 8;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(812, 55);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(80, 29);
            this.txtstock.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(808, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stock:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(697, 55);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(84, 29);
            this.txtprecio.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio:";
            // 
            // txtnomproduc
            // 
            this.txtnomproduc.Location = new System.Drawing.Point(115, 56);
            this.txtnomproduc.Name = "txtnomproduc";
            this.txtnomproduc.Size = new System.Drawing.Size(266, 29);
            this.txtnomproduc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Producto";
            // 
            // txtcodigoproduc
            // 
            this.txtcodigoproduc.Location = new System.Drawing.Point(10, 56);
            this.txtcodigoproduc.Multiline = true;
            this.txtcodigoproduc.Name = "txtcodigoproduc";
            this.txtcodigoproduc.Size = new System.Drawing.Size(94, 28);
            this.txtcodigoproduc.TabIndex = 1;
            this.txtcodigoproduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoproduc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnbuscarpersonas);
            this.groupBox2.Controls.Add(this.txtapellidos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(348, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cliente:";
            // 
            // btnbuscarpersonas
            // 
            this.btnbuscarpersonas.Location = new System.Drawing.Point(522, 46);
            this.btnbuscarpersonas.Name = "btnbuscarpersonas";
            this.btnbuscarpersonas.Size = new System.Drawing.Size(75, 29);
            this.btnbuscarpersonas.TabIndex = 5;
            this.btnbuscarpersonas.Text = "Buscar";
            this.btnbuscarpersonas.UseVisualStyleBackColor = true;
            this.btnbuscarpersonas.Click += new System.EventHandler(this.btnbuscarpersonas_Click);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(97, 47);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(408, 29);
            this.txtapellidos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Info Venta";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Factura";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Boleta";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.optDeposito);
            this.groupBox4.Controls.Add(this.txtigv);
            this.groupBox4.Controls.Add(this.txtsubtotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.optVisa);
            this.groupBox4.Controls.Add(this.txttotal);
            this.groupBox4.Controls.Add(this.optPlin);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.optYape);
            this.groupBox4.Controls.Add(this.optEfectivo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(44, 474);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1094, 77);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modalidad de pago";
            // 
            // optDeposito
            // 
            this.optDeposito.AutoSize = true;
            this.optDeposito.Location = new System.Drawing.Point(311, 35);
            this.optDeposito.Name = "optDeposito";
            this.optDeposito.Size = new System.Drawing.Size(80, 20);
            this.optDeposito.TabIndex = 5;
            this.optDeposito.Text = "Depósito";
            this.optDeposito.UseVisualStyleBackColor = true;
            this.optDeposito.CheckedChanged += new System.EventHandler(this.optDeposito_CheckedChanged);
            // 
            // optVisa
            // 
            this.optVisa.AutoSize = true;
            this.optVisa.Location = new System.Drawing.Point(184, 35);
            this.optVisa.Name = "optVisa";
            this.optVisa.Size = new System.Drawing.Size(52, 20);
            this.optVisa.TabIndex = 4;
            this.optVisa.Text = "Visa";
            this.optVisa.UseVisualStyleBackColor = true;
            this.optVisa.CheckedChanged += new System.EventHandler(this.optVisa_CheckedChanged);
            // 
            // optPlin
            // 
            this.optPlin.AutoSize = true;
            this.optPlin.Location = new System.Drawing.Point(258, 35);
            this.optPlin.Name = "optPlin";
            this.optPlin.Size = new System.Drawing.Size(47, 20);
            this.optPlin.TabIndex = 3;
            this.optPlin.Text = "Plin";
            this.optPlin.UseVisualStyleBackColor = true;
            this.optPlin.CheckedChanged += new System.EventHandler(this.optPlin_CheckedChanged);
            // 
            // optYape
            // 
            this.optYape.AutoSize = true;
            this.optYape.Location = new System.Drawing.Point(101, 35);
            this.optYape.Name = "optYape";
            this.optYape.Size = new System.Drawing.Size(58, 20);
            this.optYape.TabIndex = 2;
            this.optYape.Text = "Yape";
            this.optYape.UseVisualStyleBackColor = true;
            this.optYape.CheckedChanged += new System.EventHandler(this.optYape_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Location = new System.Drawing.Point(9, 35);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(73, 20);
            this.optEfectivo.TabIndex = 1;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 646);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.btnagregarprod);
            this.Controls.Add(this.dgvventas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnagregarprod;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbuscarproduc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnomproduc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigoproduc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnbuscarpersonas;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton optDeposito;
        private System.Windows.Forms.RadioButton optVisa;
        private System.Windows.Forms.RadioButton optPlin;
        private System.Windows.Forms.RadioButton optYape;
        private System.Windows.Forms.RadioButton optEfectivo;
    }
}