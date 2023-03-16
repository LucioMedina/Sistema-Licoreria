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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btnguardarpro = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.txtnombreproduc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvcategorias = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbeditarcategoria = new System.Windows.Forms.RadioButton();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.btneditarcategoria = new System.Windows.Forms.Button();
            this.btnguardarcategoria = new System.Windows.Forms.Button();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvmarcas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbedi = new System.Windows.Forms.RadioButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnedi = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 604);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dgvproductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.cbcategoria);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.btnguardarpro);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.txtcodigo);
            this.groupBox3.Controls.Add(this.btneditar);
            this.groupBox3.Controls.Add(this.cbmarca);
            this.groupBox3.Controls.Add(this.txtnombreproduc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(51, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 177);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(633, 138);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Editar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidproducto.Location = new System.Drawing.Point(379, 26);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 22);
            this.txtidproducto.TabIndex = 18;
            this.txtidproducto.Visible = false;
            // 
            // cbcategoria
            // 
            this.cbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(12, 98);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(148, 24);
            this.cbcategoria.TabIndex = 2;
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(12, 144);
            this.txtstock.MaxLength = 4;
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(148, 22);
            this.txtstock.TabIndex = 6;
            // 
            // btnguardarpro
            // 
            this.btnguardarpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarpro.Location = new System.Drawing.Point(502, 40);
            this.btnguardarpro.Name = "btnguardarpro";
            this.btnguardarpro.Size = new System.Drawing.Size(144, 36);
            this.btnguardarpro.TabIndex = 8;
            this.btnguardarpro.Text = "Guardar";
            this.btnguardarpro.UseVisualStyleBackColor = true;
            this.btnguardarpro.Click += new System.EventHandler(this.btnguardarpro_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(193, 144);
            this.txtprecio.MaxLength = 9;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(168, 22);
            this.txtprecio.TabIndex = 5;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(12, 54);
            this.txtcodigo.MaxLength = 30;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(148, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(504, 98);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(142, 38);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // cbmarca
            // 
            this.cbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(193, 98);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(168, 24);
            this.cbmarca.TabIndex = 3;
            // 
            // txtnombreproduc
            // 
            this.txtnombreproduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproduc.Location = new System.Drawing.Point(193, 54);
            this.txtnombreproduc.MaxLength = 30;
            this.txtnombreproduc.Name = "txtnombreproduc";
            this.txtnombreproduc.Size = new System.Drawing.Size(168, 22);
            this.txtnombreproduc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marca:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Categoria:";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.AllowUserToDeleteRows = false;
            this.dgvproductos.AllowUserToResizeRows = false;
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(15, 190);
            this.dgvproductos.MultiSelect = false;
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductos.Size = new System.Drawing.Size(790, 382);
            this.dgvproductos.TabIndex = 5;
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvcategorias);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvcategorias
            // 
            this.dgvcategorias.AllowUserToAddRows = false;
            this.dgvcategorias.AllowUserToDeleteRows = false;
            this.dgvcategorias.AllowUserToResizeRows = false;
            this.dgvcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategorias.Location = new System.Drawing.Point(31, 125);
            this.dgvcategorias.MultiSelect = false;
            this.dgvcategorias.Name = "dgvcategorias";
            this.dgvcategorias.ReadOnly = true;
            this.dgvcategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcategorias.Size = new System.Drawing.Size(754, 421);
            this.dgvcategorias.TabIndex = 6;
            this.dgvcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategorias_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbeditarcategoria);
            this.groupBox1.Controls.Add(this.txtidcategoria);
            this.groupBox1.Controls.Add(this.btneditarcategoria);
            this.groupBox1.Controls.Add(this.btnguardarcategoria);
            this.groupBox1.Controls.Add(this.txtcategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // dbeditarcategoria
            // 
            this.dbeditarcategoria.AutoSize = true;
            this.dbeditarcategoria.Location = new System.Drawing.Point(696, 58);
            this.dbeditarcategoria.Name = "dbeditarcategoria";
            this.dbeditarcategoria.Size = new System.Drawing.Size(52, 17);
            this.dbeditarcategoria.TabIndex = 9;
            this.dbeditarcategoria.TabStop = true;
            this.dbeditarcategoria.Text = "Editar";
            this.dbeditarcategoria.UseVisualStyleBackColor = true;
            this.dbeditarcategoria.CheckedChanged += new System.EventHandler(this.dbeditarcategoria_CheckedChanged);
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(9, 58);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtidcategoria.TabIndex = 8;
            this.txtidcategoria.Visible = false;
            // 
            // btneditarcategoria
            // 
            this.btneditarcategoria.Location = new System.Drawing.Point(540, 29);
            this.btneditarcategoria.Name = "btneditarcategoria";
            this.btneditarcategoria.Size = new System.Drawing.Size(75, 23);
            this.btneditarcategoria.TabIndex = 7;
            this.btneditarcategoria.Text = "Editar";
            this.btneditarcategoria.UseVisualStyleBackColor = true;
            // 
            // btnguardarcategoria
            // 
            this.btnguardarcategoria.Location = new System.Drawing.Point(445, 29);
            this.btnguardarcategoria.Name = "btnguardarcategoria";
            this.btnguardarcategoria.Size = new System.Drawing.Size(75, 23);
            this.btnguardarcategoria.TabIndex = 7;
            this.btnguardarcategoria.Text = "Registrar";
            this.btnguardarcategoria.UseVisualStyleBackColor = true;
            this.btnguardarcategoria.Click += new System.EventHandler(this.btnguardarcategoria_Click);
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(9, 32);
            this.txtcategoria.MaxLength = 30;
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(222, 20);
            this.txtcategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvmarcas);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(824, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marcas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvmarcas
            // 
            this.dgvmarcas.AllowUserToAddRows = false;
            this.dgvmarcas.AllowUserToDeleteRows = false;
            this.dgvmarcas.AllowUserToResizeRows = false;
            this.dgvmarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvmarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmarcas.Location = new System.Drawing.Point(19, 130);
            this.dgvmarcas.MultiSelect = false;
            this.dgvmarcas.Name = "dgvmarcas";
            this.dgvmarcas.ReadOnly = true;
            this.dgvmarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmarcas.Size = new System.Drawing.Size(754, 421);
            this.dgvmarcas.TabIndex = 7;
            this.dgvmarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmarcas_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbedi);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.btnedi);
            this.groupBox2.Controls.Add(this.btnregistro);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(19, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // rbedi
            // 
            this.rbedi.AutoSize = true;
            this.rbedi.Location = new System.Drawing.Point(696, 58);
            this.rbedi.Name = "rbedi";
            this.rbedi.Size = new System.Drawing.Size(52, 17);
            this.rbedi.TabIndex = 9;
            this.rbedi.TabStop = true;
            this.rbedi.Text = "Editar";
            this.rbedi.UseVisualStyleBackColor = true;
            this.rbedi.CheckedChanged += new System.EventHandler(this.rbedi_CheckedChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(456, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            this.txtid.Visible = false;
            // 
            // btnedi
            // 
            this.btnedi.Location = new System.Drawing.Point(290, 29);
            this.btnedi.Name = "btnedi";
            this.btnedi.Size = new System.Drawing.Size(75, 23);
            this.btnedi.TabIndex = 7;
            this.btnedi.Text = "Editar";
            this.btnedi.UseVisualStyleBackColor = true;
            this.btnedi.Click += new System.EventHandler(this.btnedi_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(200, 28);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(75, 23);
            this.btnregistro.TabIndex = 7;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(9, 32);
            this.txtmarca.MaxLength = 30;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(157, 20);
            this.txtmarca.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Marca:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(662, 622);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(148, 27);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(824, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reportes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reportes de ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reportes de compras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 660);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvcategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dbeditarcategoria;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.Button btneditarcategoria;
        private System.Windows.Forms.Button btnguardarcategoria;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbedi;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnedi;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvmarcas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Button btnguardarpro;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.TextBox txtnombreproduc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

