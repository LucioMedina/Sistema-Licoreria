using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DESIGNER.Modal;
using BOL;
using ENTITIES;
namespace DESIGNER.Mantenimieto
{
    public partial class FormDetalleP : Form
    {
        Persona persona = new Persona();
        Producto producto = new Producto();
        public EProducto entidadproducto = new EProducto();

       
      

        public EPersona entidadpersona { get; set; }

        public FormDetalleP(Persona oempleado = null)
        {
            persona = oempleado;
            InitializeComponent();
            dgvdetalleventa.Columns.Add("codigo", "CODIGO");
            dgvdetalleventa.Columns.Add("producto","PRODUCTO");
            dgvdetalleventa.Columns.Add("descripcion", "Descripción");
            dgvdetalleventa.Columns.Add("cantidad", "CANTIDAD");
            dgvdetalleventa.Columns.Add("precio", "PRECIO");
            dgvdetalleventa.Columns.Add("total", "TOTAL");
          

        }

        private void FormDetalleP_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbuscardni_Click(object sender, EventArgs e)
        {
            using (var modal = new DESIGNER.Modal.FormCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdni.Text = modal.entidadpersona.dni;
                    txtapellidos.Text = modal.entidadpersona.apellidos;
                    
                    txtcodigo.Select();
                }
                else
                {
                    txtdni.Select();
                    
                }

            }
            
        }

        private void btnbuscarproduc_Click(object sender, EventArgs e)
        {
            using (var modal = new DESIGNER.Modal.FormProdts())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtcodigo.Text = modal.entidadproducto.codigo;
                    txtnombreproduc.Text = modal.entidadproducto.nombreproducto;
                    txtdescripcion.Text = modal.entidadproducto.descripcion;
                    txtprec.Text = modal.entidadproducto.precio.ToString();
                    txtstok.Text = modal.entidadproducto.stock.ToString();
                    
                    txtcodigo.Select();
                }
                else
                { 
                    txtcodigo.Select();
                    //txtapellidos.Select();
                }

            }
        }
        private void sumarfilas()
        {
            if(dgvdetalleventa.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvdetalleventa.Rows)
                {
                    //decimal num0 = decimal.Parse(row.Cells[1].Value.ToString());
                    //decimal num1 = decimal.Parse(row.Cells[2].Value.ToString());
                    decimal num2 = Convert.ToDecimal(row.Cells[3].Value);
                    decimal num3 = Convert.ToDecimal(row.Cells[4].Value);

                    row.Cells[5].Value =(num2 * num3);
                }
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            dgvdetalleventa.Rows.Add(txtcodigo.Text,txtnombreproduc.Text,txtdescripcion.Text, nudcantidad.Value, txtprec.Text,0.00);
            
        }

    

        private void limpiarProducto()
        {
            txtcodigo.Text = "";
            txtnombreproduc.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            nudcantidad.Value = 1;
        }

        private void dgvdetalleventa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            sumarcolumnas();
            sumarfilas();
            

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            
        }

        public void sumarcolumnas()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvdetalleventa.Rows)
            {
                total += Convert.ToDecimal(row.Cells[4].Value);
            }
            txttotalsun.Text = total.ToString();
        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {
            //restarvuelto();
        }

        //public void restarvuelto()
        //{
        //   txtcambio.Text = (Convert.ToInt32(txttotalsun.Text) - Convert.ToInt32(txtpaga.Text)).ToString();

        //}
    }
}
