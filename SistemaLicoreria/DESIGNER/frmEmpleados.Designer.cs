namespace DESIGNER
{
    partial class frmEmpleados
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
            this.GridEmpleados = new System.Windows.Forms.DataGridView();
            this.txtBuscarEmple = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEmpleados
            // 
            this.GridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpleados.Location = new System.Drawing.Point(12, 232);
            this.GridEmpleados.Name = "GridEmpleados";
            this.GridEmpleados.Size = new System.Drawing.Size(776, 206);
            this.GridEmpleados.TabIndex = 0;
            this.GridEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBuscarEmple
            // 
            this.txtBuscarEmple.Location = new System.Drawing.Point(67, 35);
            this.txtBuscarEmple.Name = "txtBuscarEmple";
            this.txtBuscarEmple.Size = new System.Drawing.Size(174, 20);
            this.txtBuscarEmple.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarEmple);
            this.Controls.Add(this.GridEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEmpleados;
        private System.Windows.Forms.TextBox txtBuscarEmple;
        private System.Windows.Forms.Label label1;
    }
}