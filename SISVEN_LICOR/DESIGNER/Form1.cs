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
using DAL;
using System.Data.SqlClient;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using DESIGNER.Reportes;

namespace DESIGNER
{
    public partial class Form1 : Form
    {
        Marca marca = new Marca();
        EMarca entidadmarca = new EMarca();

        Categoria categoria = new Categoria();
        ECategoria entidadcategoria = new ECategoria();

        Producto producto = new Producto();
        EProducto entidadproducto = new EProducto();
        DBAccess accesso = new DBAccess();

        VisorReportes formulario;
        SaveFileDialog saveFileDialog;
        public Form1()
        {
            InitializeComponent();
        }

        
        public void cargarcategorias()
        {
            accesso.conectar();
            SqlCommand cmd = new SqlCommand("Select * from categorias", accesso.getConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            accesso.desconectar();

            DataRow fila = dt.NewRow();
            fila["categoria"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cbcategoria.ValueMember = "idcategoria";
            cbcategoria.DisplayMember = "categoria";
            cbcategoria.DataSource = dt;
            cbcategoria.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public void cargarmarcas()
        {
            accesso.conectar();
            SqlCommand cmd = new SqlCommand("Select * from marcas", accesso.getConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            accesso.desconectar();

            DataRow fila = dt.NewRow();
            fila["marca"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cbmarca.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbmarca.ValueMember = "idmarca";
            cbmarca.DisplayMember = "marca";
            cbmarca.DataSource = dt;
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            
            if (txtmarca.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("complete el campo por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos la Marca") == DialogResult.Yes)
                {
                    

                    entidadmarca.marca = txtmarca.Text.Trim();

                    if (marca.registrar(entidadmarca) > 0)
                    {

                        
                        dgvmarcas.DataSource = marca.listar();

                        txtmarca.Clear();
                        txtid.Clear();


                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        private void btnedi_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtid.Text.Trim() == String.Empty ||
                txtmarca.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                    

                    entidadmarca.idmarca = Convert.ToInt16(txtid.Text.Trim());
                    entidadmarca.marca = txtmarca.Text.Trim();

                    
                    if (marca.editar(entidadmarca) > 0)
                    {

                        
                        dgvmarcas.DataSource = marca.listar();

                        txtid.Clear();
                        txtmarca.Clear();
                        rbedi.Checked = false;
                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void dgvmarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvmarcas.CurrentRow.Cells[0].Value.ToString();
            txtmarca.Text = dgvmarcas.CurrentRow.Cells[1].Value.ToString();
        }

        private void rbedi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbedi.Checked == true)
            {
                dgvmarcas.DataSource = marca.listar();
                dgvmarcas.Refresh();
            }
        }

        private void btnguardarcategoria_Click(object sender, EventArgs e)
        {
           
            if (txtcategoria.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("complete el campo por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos a la Categoria?") == DialogResult.Yes)
                {
                   

                    entidadcategoria.categoria = txtcategoria.Text.Trim();

                    
                    if (categoria.registrar(entidadcategoria) > 0)
                    {

                        
                        dgvcategorias.DataSource = categoria.listar();

                        txtcategoria.Clear();
                        txtidcategoria.Clear();


                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el registro");
                    }
                }
            }
        }

        private void dbeditarcategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbedi.Checked == true)
            {
                dgvcategorias.DataSource = categoria.listar();
                dgvcategorias.Refresh();
            }
        }

        private void dgvcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcategoria.Text = dgvcategorias.CurrentRow.Cells[0].Value.ToString();
            txtcategoria.Text = dgvcategorias.CurrentRow.Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarcategorias();
            cargarmarcas();
        }

        private void btnguardarpro_Click(object sender, EventArgs e)
        {
            
            if (txtcodigo.Text.Trim() == String.Empty ||
                txtnombreproduc.Text.Trim() == String.Empty ||
                cbcategoria.Text.Trim() == String.Empty ||
                cbmarca.Text.Trim() == String.Empty ||
                
                txtprecio.Text.Trim() == String.Empty ||
                txtstock.Text.Trim() == String.Empty 
                )
            {
                Dialogo.Informar("complete todos los campos por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos el producto?") == DialogResult.Yes)
                {
                    

                    entidadproducto.codigo = txtcodigo.Text.Trim();
                    entidadproducto.idcategoria = Convert.ToInt16(cbcategoria.SelectedValue.ToString());
                    entidadproducto.idmarca = Convert.ToInt16(cbmarca.SelectedValue.ToString());
                    entidadproducto.nombre = txtnombreproduc.Text.Trim();
                   
                    entidadproducto.precio = Convert.ToDecimal(txtprecio.Text.Trim());
                    entidadproducto.stock = Convert.ToInt16(txtstock.Text.Trim());
                    

                    
                    if (producto.registrar(entidadproducto) > 0)
                    {

                        
                        dgvproductos.DataSource = producto.listar();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el producto");
                    }
                    cargarmarcas();
                    cargarcategorias();
                    txtnombreproduc.Clear();
                    txtcodigo.Clear();
                    txtprecio.Clear();
                    txtstock.Clear();


                }

            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
            if (txtcodigo.Text.Trim() == String.Empty ||
                txtnombreproduc.Text.Trim() == String.Empty ||
                txtprecio.Text.Trim() == String.Empty ||
                txtstock.Text.Trim() == String.Empty ||
                cbcategoria.Text.Trim() == String.Empty ||
                cbmarca.Text.Trim() == String.Empty ||
                txtidproducto.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                   

                    entidadproducto.codigo = txtcodigo.Text.Trim();
                    entidadproducto.idcategoria = Convert.ToInt16(cbcategoria.SelectedValue.ToString());
                    entidadproducto.idmarca = Convert.ToInt16(cbmarca.SelectedValue.ToString());
                    entidadproducto.nombre = txtnombreproduc.Text.Trim();
                    entidadproducto.precio = Convert.ToDecimal(txtprecio.Text.Trim());
                    entidadproducto.stock = Convert.ToInt16(txtstock.Text.Trim());
                    entidadproducto.idproducto = Convert.ToInt16(txtidproducto.Text.Trim());
                  
                    if (producto.editar(entidadproducto) > 0)
                    {

                      
                        dgvproductos.DataSource = producto.listar();

                        cargarmarcas();
                        cargarcategorias();
                        txtnombreproduc.Clear();
                        txtcodigo.Clear();
                        txtprecio.Clear();
                        txtstock.Clear();
                        radioButton1.Checked = false;               
                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                dgvproductos.DataSource =producto.listarproduc();
                dgvproductos.Refresh();
            }
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproducto.Text = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dgvproductos.CurrentRow.Cells[1].Value.ToString();
            cbcategoria.Text = dgvproductos.CurrentRow.Cells[2].Value.ToString();
            cbmarca.Text = dgvproductos.CurrentRow.Cells[3].Value.ToString();
            txtnombreproduc.Text = dgvproductos.CurrentRow.Cells[4].Value.ToString();
            txtstock.Text = dgvproductos.CurrentRow.Cells[5].Value.ToString();
            txtprecio.Text = dgvproductos.CurrentRow.Cells[6].Value.ToString();
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }


        private void exportarPDF(ReportClass reporteVisualizar, string titulo)
        {
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Exportando datos como PDF";
            saveFileDialog.Filter = "*.PDF|*.pdf";
            saveFileDialog.FileName = "Reporte de " + titulo;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                reporteVisualizar.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarPDF(new ReporteProductos(), "Productos");
        }
    }
}
