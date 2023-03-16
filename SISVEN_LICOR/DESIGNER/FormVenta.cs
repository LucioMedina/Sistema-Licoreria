using BOL;
using DESIGNER.Herramientas;
using DESIGNER.Modales;
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
    public partial class FormVenta : Form
    {
        
        Venta venta = new Venta();
        Producto producto = new Producto();

        
        EVenta entidadVenta = new EVenta();
        EDventa entidadDV = new EDventa();

       
        DataTable dtBuscadorProducto = new DataTable();
        Moneda moneda = new Moneda();

        int idproducto = -1;
        public FormVenta()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipocomprobante = 'B';
        }

        private void btnbuscarpersonas_Click(object sender, EventArgs e)
        {
            Modales.FormBuscarPerso formBusqueda = new Modales.FormBuscarPerso();
            formBusqueda.ShowDialog();

            if (formBusqueda.idcliente != -1)
            {
               
                entidadVenta.idpersona = formBusqueda.idcliente;

                
                txtapellidos.Text = formBusqueda.datosCliente;
                
            }
        }

        private void limpiarCamposProducto()
        {
            txtcodigoproduc.Clear();
            txtnomproduc.Clear();
            txtstock.Clear();
            txtprecio.Clear();
            txtcantidad.Value = 1;
        }

        private void txtcodigoproduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtcodigoproduc.Text.Trim() != String.Empty && e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtBuscadorProducto = producto.buscarCodigo(txtcodigoproduc.Text);

                if (dtBuscadorProducto.Rows.Count > 0)
                {
                    idproducto = Convert.ToInt32(dtBuscadorProducto.Rows[0][0].ToString());
                    txtnomproduc.Text = dtBuscadorProducto.Rows[0][1].ToString();
                    txtstock.Text = dtBuscadorProducto.Rows[0][2].ToString();
                    txtprecio.Text = dtBuscadorProducto.Rows[0][3].ToString();

                    txtcantidad.Maximum = Convert.ToDecimal(txtstock.Text);
                    btnagregarprod.Focus();
                }
                else
                {
                    limpiarCamposProducto();
                }
            }
        }

        private bool existeDuplicado(int idtmp)
        {
            int i = 0;
            int cantidadSolicitada = 0;
            decimal nuevoImporte = 0;
            bool encontrado = false;

            
            if (dgvventas.Rows.Count > 0)
            {
                while (i < dgvventas.Rows.Count && !encontrado)
                {
                    
                    if (Convert.ToInt32(dgvventas.Rows[i].Cells[1].Value) == idtmp)
                    {
                       
                        cantidadSolicitada = Convert.ToInt32(dgvventas.Rows[i].Cells[0].Value) + Convert.ToInt32(txtcantidad.Value);

                        if (cantidadSolicitada > Convert.ToInt32(txtstock.Text))
                        {
                            MessageBox.Show(
                                "No podemos atender su pedido porque sobrepasa el stock",
                                "Infotec ventas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtcantidad.Focus();
                        }
                        else
                        {
                           
                            dgvventas.Rows[i].Cells[0].Value = cantidadSolicitada;

                            
                            nuevoImporte = Convert.ToDecimal(txtprecio.Text) * cantidadSolicitada;
                            dgvventas.Rows[i].Cells[4].Value = nuevoImporte;

                            limpiarCamposProducto();
                            txtcodigoproduc.Focus();
                        }

                        encontrado = true;
                    }

                    i++;
                }
            }

            return encontrado;
        }

        private void btnagregarprod_Click(object sender, EventArgs e)
        {
           
            if (idproducto != -1)
            {
                if (!existeDuplicado(idproducto))
                {
                    decimal importe = Convert.ToDecimal(txtprecio.Text) * txtcantidad.Value;

                    dgvventas.Rows.Add(txtcantidad.Value.ToString(), idproducto.ToString(), txtnomproduc.Text, txtprecio.Text, importe.ToString());
                    actualizarTotales();
                    idproducto = -1;

                    limpiarCamposProducto();
                    txtcodigoproduc.Focus();
                }
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
           
            dgvventas.Columns[0].Width = 100;
            
            dgvventas.Columns[2].Width = 600;
            dgvventas.Columns[3].Width = 100;
            dgvventas.Columns[4].Width = 100;

            
            DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
            colBoton.Name = "colQuitar";
            colBoton.Text = "Quitar";
            colBoton.HeaderText = "Quitar";
            colBoton.UseColumnTextForButtonValue = true;
            dgvventas.Columns.Add(colBoton);

            
            entidadVenta.tipocomprobante = 'B';
            entidadVenta.numcomprobante = 1; 
            entidadVenta.idpersona = -1;
            entidadVenta.tipopago = "efectivo";

            
            dgvventas.Columns[5].Width = 100;
        }


        private void actualizarTotales()
        {
            double neto = 0, igv = 0, subtotal = 0;

            if (dgvventas.Rows.Count > 0)
            {
                for (int i = 0; i < dgvventas.Rows.Count; i++)
                {
                    neto += Convert.ToDouble(dgvventas.Rows[i].Cells[4].Value);
                }

                subtotal = neto / 1.18;
                igv = neto - subtotal;
            }

            txtsubtotal.Text = subtotal.ToString("0.00");
            txtigv.Text = igv.ToString("0.00");
            txttotal.Text = neto.ToString("0.00");

            txtletras.Text = moneda.enLetras(txttotal.Text);
        }

        private void dgvventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvventas.Columns[e.ColumnIndex].Name == "colQuitar")
            {
                string descripcion = dgvventas.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (MessageBox.Show(
                    "¿Confirma retirar este producto de la lista?\n" + descripcion,
                    "Licoreria Ventas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvventas.Rows.RemoveAt(e.RowIndex);
                    actualizarTotales();
                }
            }
        }

        private void btnbuscarproduc_Click(object sender, EventArgs e)
        {
            FormbuscarProduc frmBuscadorProducto = new FormbuscarProduc();
            frmBuscadorProducto.ShowDialog();

            if (frmBuscadorProducto.idproducto != -1)
            {
                int stock = frmBuscadorProducto.stock;
                decimal precio = frmBuscadorProducto.precio;

                idproducto = frmBuscadorProducto.idproducto;
                txtnomproduc.Text = frmBuscadorProducto.datosProducto;
                txtstock.Text = stock.ToString();
                txtprecio.Text = precio.ToString();
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "efectivo";
        }

        private void optYape_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "yape";
        }

        private void optPlin_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "plin";
        }

        private void optVisa_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "visa";
        }

        private void optDeposito_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipopago = "deposito";
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            
            if (dgvventas.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No ha indicado productos",
                    "Licoraria Ventas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtcodigoproduc.Focus();
            }
            else
            {
                
                if (MessageBox.Show(
                    "¿Desea dar por finalizar esta venta?",
                    "Licoreria Ventas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    int idVentaObtenido = venta.registrar(entidadVenta);

                    if (idVentaObtenido == -1)
                    {
                        MessageBox.Show(
                            "Existen errores, consulte al administrador del sistema",
                            "Licoreria Ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        enviarTodosProductos(idVentaObtenido);
                    }
                }
            }
        }


        private void enviarTodosProductos(int idventa)
        {
            for (int i = 0; i < dgvventas.Rows.Count; i++)
            {
                entidadDV.idventa = idventa;
                entidadDV.cantidad = Convert.ToInt32(dgvventas.Rows[i].Cells[0].Value);
                entidadDV.idproducto = Convert.ToInt32(dgvventas.Rows[i].Cells[1].Value);
                entidadDV.precioventa = Convert.ToDecimal(dgvventas.Rows[i].Cells[3].Value);

                venta.registrarDetalle(entidadDV);
            }


            txtapellidos.Clear();
           

            limpiarCamposProducto();
            dgvventas.Rows.Clear();

            radioButton1.Checked = true;
            optEfectivo.Checked = true;

            entidadVenta.tipocomprobante = 'B';
            entidadVenta.numcomprobante = 1;
            entidadVenta.idpersona = -1;
            entidadVenta.tipopago = "efectivo";

            txtletras.Text = "";
            txtsubtotal.Clear();
            txtigv.Clear();
            txttotal.Clear();

            MessageBox.Show(
                "Se registró una venta ",
                "Licoreria ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            entidadVenta.tipocomprobante = 'F';
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();

            form1.ShowDialog();
        }
    }
}
