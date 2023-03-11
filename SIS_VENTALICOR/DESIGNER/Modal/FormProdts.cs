using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;
using DESIGNER.Modal;
using ENTITIES;
namespace DESIGNER.Modal
{
    public partial class FormProdts : Form
    {
        Producto producto = new Producto();
        public EProducto entidadproducto { get; set; }
        public FormProdts()
        {
            InitializeComponent();
        }

        private void dgvprodts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                entidadproducto = new EProducto()
                {
                    codigo = dgvprodts.Rows[iRow].Cells[0].Value.ToString(),
                    nombreproducto= dgvprodts.Rows[iRow].Cells[1].Value.ToString(),
                    descripcion = dgvprodts.Rows[iRow].Cells[2].Value.ToString(),
                    precio =dgvprodts.Rows[iRow].Cells[3].Value.ToString(),
                    stock = dgvprodts.Rows[iRow].Cells[4].Value.ToString(),
               
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormProdts_Load(object sender, EventArgs e)
        {
            dgvprodts.DataSource = producto.listarproductos();
            dgvprodts.Refresh();

            //dgvprodts.Columns[0].Visible = false;
            //dgvprodts.Columns[1].Visible = false;
        }
    }
}
