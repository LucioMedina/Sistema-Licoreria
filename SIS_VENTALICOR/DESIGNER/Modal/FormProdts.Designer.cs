namespace DESIGNER.Modal
{
    partial class FormProdts
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
            this.dgvprodts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprodts
            // 
            this.dgvprodts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprodts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprodts.Location = new System.Drawing.Point(44, 30);
            this.dgvprodts.Name = "dgvprodts";
            this.dgvprodts.Size = new System.Drawing.Size(813, 525);
            this.dgvprodts.TabIndex = 0;
            this.dgvprodts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprodts_CellDoubleClick);
            // 
            // FormProdts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 594);
            this.Controls.Add(this.dgvprodts);
            this.Name = "FormProdts";
            this.Text = "FormProdts";
            this.Load += new System.EventHandler(this.FormProdts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprodts;
    }
}