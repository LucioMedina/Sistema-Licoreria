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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimieto.FormPerson formPerson = new Mantenimieto.FormPerson();
            formPerson.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimieto.FormEmpleado formEmpleado = new Mantenimieto.FormEmpleado();
            formEmpleado.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimieto.FormDetalleP formDetalleP = new Mantenimieto.FormDetalleP();
            formDetalleP.Show();
        }
    }
}
