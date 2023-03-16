using BOL;
using DAL;
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

namespace DESIGNER
{
    public partial class Login : Form
    {
        DBAccess acceso = new DBAccess();
        Usuario empleado = new Usuario();
        EUsuario entidademmpleado = new EUsuario();
        public Login()
        {
            InitializeComponent();
        }


        private void btniniciar_Click_1(object sender, EventArgs e)
        {
            if (acceso.consultarlogin(txtusuario.Text, txtclave.Text) == 1)
            {
                Form1 frm = new Form1();

                this.Hide();
                frm.Show();
            }
            else
            {
                Dialogo.Informar("Datos Incorrecto! Vuelva a ingresar");

                txtusuario.Clear();
                txtclave.Clear();
                txtusuario.Focus();
            }
        }

     

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (acceso.consultarlogin(txtusuario.Text, txtclave.Text) == 1)
                {
                    Form1 frm = new Form1();

                    this.Hide();
                    frm.Show();
                }
                else
                {
                    Dialogo.Informar("Datos Incorrecto! Vuelva a ingresar");

                    txtusuario.Clear();
                    txtclave.Clear();
                    txtusuario.Focus();
                }
            }
        }
    }
}
