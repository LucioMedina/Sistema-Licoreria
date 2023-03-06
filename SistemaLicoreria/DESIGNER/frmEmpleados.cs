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

namespace DESIGNER
{
    public partial class frmEmpleados : Form
    {
        Empleado empleado = new Empleado();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            GridEmpleados.DataSource = empleado.listarActivos();
        }
    }
}
