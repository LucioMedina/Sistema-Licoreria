using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

using DESIGNER.Herramientas;
using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimieto
{
    public partial class FormPerson : Form
    {
        Persona persona = new Persona();
        EPersona entidadpersona = new EPersona();
        public FormPerson()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtapellidos.Text.Trim() == String.Empty ||
                txtnombres.Text.Trim() == String.Empty ||
                txtdni.Text.Trim().Length != 8 ||
                txttelefono.Text.Trim().Length != 9)
            {
                 Dialogo.Informar("complete los 4 primeros campos por favor");
            }
            else
            {
                if ( Dialogo.Preguntar("¿Registramos la Persona?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadpersona.apellidos = txtapellidos.Text.Trim();
                    entidadpersona.nombres = txtnombres.Text.Trim();
                    entidadpersona.dni = txtdni.Text.Trim();
                    entidadpersona.telefono = txttelefono.Text.Trim();
                    //La entidad es enviada al metodo como parametro
                    if (persona.registrar(entidadpersona) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvpersonas.DataSource = persona.listarActivos();

                        txtapellidos.Clear();
                        txtnombres.Clear();
                        txtdni.Clear();
                        txttelefono.Clear();
                        
                    }
                    else
                    {
                        
                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            dgvpersonas.DataSource = persona.listarActivos();
            dgvpersonas.Refresh();

            //Configuramos el datagridview
            dgvpersonas.Columns[0].Width = 50; //id
            dgvpersonas.Columns[1].Width = 200; //Apellidos
            dgvpersonas.Columns[2].Width = 200; //Nombres
            dgvpersonas.Columns[3].Width = 100; //Dni
            dgvpersonas.Columns[4].Width = 100; //Telefono

            dgvpersonas.Columns[0].HeaderText = "ID";
            dgvpersonas.Columns[1].HeaderText = "Apellidos";
            dgvpersonas.Columns[2].HeaderText = "Nombres";
            dgvpersonas.Columns[3].HeaderText = "DNI";
            dgvpersonas.Columns[4].HeaderText = "Teléfono";

            dgvpersonas.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtapellidos.Text.Trim() == String.Empty ||
                txtnombres.Text.Trim() == String.Empty ||
                txtdni.Text.Trim().Length != 8 ||
                txttelefono.Text.Trim().Length != 9 ||
                txtidpersona.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadpersona.apellidos = txtapellidos.Text.Trim();
                    entidadpersona.nombres = txtnombres.Text.Trim();
                    entidadpersona.dni = txtdni.Text.Trim();
                    entidadpersona.telefono = txttelefono.Text.Trim();
                    entidadpersona.idpersona = Convert.ToInt32(txtidpersona.Text);
                    //La entidad es enviada al metodo como parametro
                    if (persona.editar(entidadpersona) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvpersonas.DataSource = persona.listarActivos();

                        txtapellidos.Clear();
                        txtnombres.Clear();
                        txtdni.Clear();
                        txttelefono.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void dgvpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidpersona.Text = dgvpersonas.CurrentRow.Cells[0].Value.ToString();
            txtapellidos.Text = dgvpersonas.CurrentRow.Cells[1].Value.ToString();
            txtnombres.Text = dgvpersonas.CurrentRow.Cells[2].Value.ToString();
            txtdni.Text = dgvpersonas.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgvpersonas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtidpersona.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de eliminar?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadpersona.idpersona = Convert.ToInt32(txtidpersona.Text);
                    //La entidad es enviada al metodo como parametro
                    if (persona.eliminar(entidadpersona) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvpersonas.DataSource = persona.listarActivos();

                        txtapellidos.Clear();
                        txtnombres.Clear();
                        txtdni.Clear();
                        txttelefono.Clear();
                        txtidpersona.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 v1 = new Form1();
            v1.Show();
        }
    }
}
