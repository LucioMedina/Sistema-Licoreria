using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DESIGNER.Herramientas;
using BOL;
using ENTITIES;

namespace DESIGNER.Mantenimieto
{
    public partial class FormEmpleado : Form
    {
        Empleado empleado = new Empleado();
        EEmpleado entidadempleado = new EEmpleado();
        Persona persona = new Persona();
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtidperso.Text.Trim() == String.Empty ||
                txtusuario.Text.Trim() == String.Empty ||
                txtclave.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("complete los todos campos por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos la Persona?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadempleado.idpersona = Convert.ToInt32(txtidperso.Text);                 
                    entidadempleado.usuario = txtusuario.Text.Trim();
                    entidadempleado.claveacceso = txtclave.Text.Trim();
                    //La entidad es enviada al metodo como parametro
                    if (empleado.registrar(entidadempleado) > 0)
                    {

                        

                        //compartimientos postinseccion de datos
                        dgvempleados.DataSource = empleado.listarActivos();

                        txtidempleado.Clear();
                        txtidperso.Clear();
                        txtusuario.Clear();
                        txtclave.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            dgvempleados.DataSource = empleado.personasusuarios();
            dgvempleados.Refresh();

            btneditar.Visible = false;
            btnguardar.Visible = true;
            btneliminar.Visible = false;

            dgvempleados.Columns[0].Width = 50; //id
        }

        private void rbeditar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbeditar.Checked == true)
            {
                btneditar.Visible = true;
                btnguardar.Visible=false;
                dgvempleados.DataSource = empleado.listarempleados();
                label1.Visible = true;
                txtidperso.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = true;
                txtidempleado.Visible = true;
                label1.Text = "Id Empleado";
            }
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 v1 = new Form1();
            v1.Show();
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidperso.Text = dgvempleados.CurrentRow.Cells[0].Value.ToString();
           
        }

        

        private void rbeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbeliminar.Checked == true)
            {
                btnguardar.Visible = false;
                btneditar.Visible =false;
                btneliminar.Visible = true;
                txtidempleado.Visible = true;
                label1.Text = "Id Empleado";
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtidperso.Visible = false;
                txtusuario.Visible = true;
                txtclave.Visible = true;
                txtidperso.Enabled = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                txtidempleado.Visible = true;

                dgvempleados.DataSource = empleado.listarempleados();
            }            
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtclave.Text.Trim() == String.Empty ||
                txtidempleado.Text.Trim() == String.Empty
                )
            {
                Dialogo.Informar("Ingrese el id para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad


                    entidadempleado.idempleado = Convert.ToInt32(txtidempleado.Text);
                    entidadempleado.claveacceso = txtclave.Text.Trim();
                    //La entidad es enviada al metodo como parametro
                    if (empleado.editar(entidadempleado) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvempleados.DataSource = empleado.listarempleados();

                        txtclave.Clear();
                        txtidempleado.Clear();


                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtidempleado.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione escriba el id");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de eliminar?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadempleado.idempleado = Convert.ToInt16(txtidempleado.Text);
                    //La entidad es enviada al metodo como parametro
                    if (empleado.eliminar(entidadempleado) > 0)
                    {

                        

                        //compartimientos postinseccion de datos
                        dgvempleados.DataSource = empleado.listarempleados();

                        txtidempleado.Clear();
                        txtclave.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo eliminar ");
                    }
                }
            }
        }
    }
}
