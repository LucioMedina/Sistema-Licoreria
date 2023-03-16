using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Modales
{
    public partial class FormbuscarProduc : Form
    {
        Producto producto = new Producto();
        DataTable dt = new DataTable();
        DataView dataView;

        
        public int idproducto = -1;
        public string datosProducto = "";
        public decimal precio = 0;
        public int stock = 0;
        public FormbuscarProduc()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = producto.listar();
            dgvprovee.DataSource = dt;
            dataView = dt.DefaultView;

            dgvprovee.Refresh();
        }

        private void FormbuscarProduc_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            dgvprovee.Columns[0].Visible = false; 
            
            dgvprovee.Columns[1].Width = 540;
            dgvprovee.Columns[2].Width = 100;
            dgvprovee.Columns[3].Width = 100;

            
            dgvprovee.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvprovee.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvprovee.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvprovee.ClearSelection();


        }

        private void frmBuscadorProducto_Activated(object sender, EventArgs e)
        {
            txtBuscadorProducto.Focus();
        }

        private void btnReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscadorProducto.Clear();
            obtenerDatos();
            txtBuscadorProducto.Focus();
        }

        private void txtBuscadorProducto_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "descripcion LIKE '%" + txtBuscadorProducto.Text.Trim() + "%'";
        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvprovee.Rows.Count > 0)
            {
                idproducto = Convert.ToInt32(dgvprovee.CurrentRow.Cells[0].Value);
                datosProducto = dgvprovee.CurrentRow.Cells[1].Value.ToString();
                stock = Convert.ToInt32(dgvprovee.CurrentRow.Cells[2].Value);
                precio = Convert.ToDecimal(dgvprovee.CurrentRow.Cells[3].Value);

                this.Close();
            }
            else
            {
                idproducto = -1;
                datosProducto = "";
                precio = 0;
                stock = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            idproducto = -1;
            datosProducto = "";
            precio = 0;
            stock = 0;
            this.Close();
        }
    }
}
