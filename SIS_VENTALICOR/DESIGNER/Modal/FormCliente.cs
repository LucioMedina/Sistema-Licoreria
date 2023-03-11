using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using BOL;
using DESIGNER.Mantenimieto;
using ENTITIES;

namespace DESIGNER.Modal
{
    public partial class FormCliente : Form
    {
        Persona persona = new Persona();
        public EPersona entidadpersona { get; set; }
        public FormCliente()//Persona objpersona = null)
        {
            //persona = objpersona;
            InitializeComponent();
        }


        private void dgvperson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                entidadpersona = new EPersona()
                {
                    dni = dgvperson.Rows[iRow].Cells[0].Value.ToString(),
                    apellidos = dgvperson.Rows[iRow].Cells[1].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dgvperson.DataSource = persona.listarclientes();
            dgvperson.Refresh();
        }
    }
}
