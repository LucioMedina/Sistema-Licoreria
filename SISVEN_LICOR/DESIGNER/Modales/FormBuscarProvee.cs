using BOL;
using ENTITIES;
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
    public partial class FormBuscarProvee : Form
    {
        Proveedor proveedor = new Proveedor();
        DataTable dt = new DataTable();
        DataView dataView;
        public FormBuscarProvee()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = proveedor.listar();
            gridProductos.DataSource = dt;
            dataView = dt.DefaultView;

            gridProductos.Refresh();
        }

        private void FormBuscarProvee_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            gridProductos.Columns[0].Visible = false; 
            
            gridProductos.Columns[1].Width = 540;
            gridProductos.Columns[2].Width = 100;
            gridProductos.Columns[3].Width = 100;

            
            gridProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            gridProductos.ClearSelection();

        }

        private void frmBuscadorProducto_Activated(object sender, EventArgs e)
        {
            txtBuscadorprovee.Focus();
        }

        private void btnReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscadorprovee.Clear();
            obtenerDatos();
            txtBuscadorprovee.Focus();
        }

        private void txtBuscadorprovee_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "nombreprov LIKE '%" + txtBuscadorprovee.Text.Trim() + "%'";
        }
    }
}
