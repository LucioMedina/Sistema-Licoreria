using BOL;
using DESIGNER.Herramientas;
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
    public partial class FormBuscarPerso : Form
    {
        Cliente cliente = new Cliente();
        DataTable dt = new DataTable();
        DataView dataView;
        ECliente entidadcliente = new ECliente();

        
        public int idcliente = -1;
        public string datosCliente = "";
        public FormBuscarPerso()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            dt = cliente.listar();
            gridClientes.DataSource = dt;
            dataView = dt.DefaultView;

            gridClientes.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            idcliente = -1;
            datosCliente = "";

            this.Close();
        }

        private void FormBuscarPerso_Load(object sender, EventArgs e)
        {
            obtenerDatos();

            
            gridClientes.Columns[0].Visible = false;
            gridClientes.Columns[1].Width = 300;
            gridClientes.Columns[2].Width = 300;
            gridClientes.Columns[3].Width = 130;

            gridClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            gridClientes.ClearSelection();
        }

        private void frmBuscadorClientes_Activated(object sender, EventArgs e)
        {
            txtBuscadorCliente.Focus();
        }

        private void gridClientes_KeyUp(object sender, KeyEventArgs e)
        {
            dataView.RowFilter = "nombres like '%" + txtBuscadorCliente.Text.Trim() + "%'";
        }

        private void btnReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscadorCliente.Clear();
            obtenerDatos();
            txtBuscadorCliente.Focus();
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridClientes.Rows.Count > 0)
            {
                idcliente = Convert.ToInt32(gridClientes.CurrentRow.Cells[0].Value);
                datosCliente = gridClientes.CurrentRow.Cells[1].Value.ToString() + " " + gridClientes.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                idcliente = -1;
                datosCliente = "";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            if (txtapellidos.Text.Trim() == String.Empty ||
                txtnombres.Text.Trim() == String.Empty ||
                txtdni.Text.Trim().Length != 8)
            {
                Dialogo.Informar("complete todo los campos por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos la Persona?") == DialogResult.Yes)
                {
                    

                    entidadcliente.apellidos = txtapellidos.Text.Trim();
                    entidadcliente.nombres = txtnombres.Text.Trim();
                    entidadcliente.dni = txtdni.Text.Trim();
                    
                    
                    if (cliente.registrar(entidadcliente) > 0)
                    {

                       
                        dgvpersonas.DataSource = cliente.listar();

                        txtapellidos.Clear();
                        txtnombres.Clear();
                        txtdni.Clear();
                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        
        

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtapellidos.Text.Trim() == String.Empty ||
                txtnombres.Text.Trim() == String.Empty ||
                txtdni.Text.Trim().Length != 8 ||
                textBox1.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                    

                    entidadcliente.apellidos = txtapellidos.Text.Trim();
                    entidadcliente.nombres = txtnombres.Text.Trim();
                    entidadcliente.dni = txtdni.Text.Trim();
                    
                    entidadcliente.idpersona = Convert.ToInt32(textBox1.Text);
                    
                    if (cliente.editar(entidadcliente) > 0)
                    {

                        
                        dgvpersonas.DataSource = cliente.listar();

                        txtapellidos.Clear();
                        txtnombres.Clear();
                        txtdni.Clear();
                        textBox1.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void dbeditar_CheckedChanged(object sender, EventArgs e)
        {
            if(dbeditar.Checked == true)
            {
                dgvpersonas.DataSource = cliente.listar();
                dgvpersonas.Refresh();
            }
        }

        private void dgvpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvpersonas.CurrentRow.Cells[0].Value.ToString();
            txtapellidos.Text = dgvpersonas.CurrentRow.Cells[1].Value.ToString();
            txtnombres.Text = dgvpersonas.CurrentRow.Cells[2].Value.ToString();
            txtdni.Text = dgvpersonas.CurrentRow.Cells[3].Value.ToString();
           
        }
    }
}
