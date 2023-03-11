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
using System.Data.SqlClient;
using DAL;

namespace DESIGNER.Mantenimieto
{
    public partial class FormProducto : Form
    {
        Producto producto = new Producto();
        EProducto entidadproducto = new EProducto();
        DBAccess accesso = new DBAccess();
        
        public FormProducto()
        {
            InitializeComponent();
            cargarcategorias();
            cargarmarcas();
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
            fila["nombrecategoria"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cbcategoria.ValueMember = "idcategoria";
            cbcategoria.DisplayMember = "nombrecategoria";
            cbcategoria.DataSource = dt;
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
            fila["nombremarca"] = "Seleccionar";
            dt.Rows.InsertAt(fila, 0);

            cbmarca.ValueMember = "idmarca";
            cbmarca.DisplayMember = "nombremarca";
            cbmarca.DataSource = dt;
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtcodigo.Text.Trim() == String.Empty ||
                txtnombreproduc.Text.Trim() == String.Empty ||
                cbcategoria.Text.Trim() == String.Empty ||
                cbmarca.Text.Trim() == String.Empty ||
                txtdescripcion.Text.Trim() == String.Empty ||
                txtprecio.Text.Trim() == String.Empty ||
                txtstock.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("complete todos los campos por favor");
            }
            else
            {
                if (Dialogo.Preguntar("¿Registramos el producto?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadproducto.idmarca = cbmarca.SelectedValue.ToString();
                    entidadproducto.idcategoria = cbcategoria.SelectedValue.ToString();
                    entidadproducto.codigo = txtcodigo.Text.Trim();
                    entidadproducto.nombreproducto = txtnombreproduc.Text.Trim();
                    entidadproducto.descripcion = txtdescripcion.Text.Trim();
                    entidadproducto.precio = txtprecio.Text.Trim();
                    entidadproducto.stock = txtstock.Text.Trim();
                    entidadproducto.caducidad = dtpcaducidad.Text.Trim();

                    //La entidad es enviada al metodo como parametro
                    if (producto.registrar(entidadproducto) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvproductos.DataSource = producto.listarActivos();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo guardar el producto");
                    }
                    cargarmarcas();
                    cargarcategorias();
                    txtnombreproduc.Clear();
                    txtcodigo.Clear();
                    txtdescripcion.Clear();
                    txtprecio.Clear();
                    txtstock.Clear();
                    
                                    
                }
            }

            //if (Dialogo.Preguntar("¿Desea guardar los datos?") == DialogResult.Yes)
            //{

            //    string marca = cbmarca.SelectedValue.ToString();
            //    string categoria = cbcategoria.SelectedValue.ToString();
            //    string nombre = txtnombreproduc.Text;
            //    string descripcion = txtdescripcion.Text;
            //    string precio = txtprecio.Text;
            //    string stock = txtstock.Text;
            //    string caducidad = dtpcaducidad.Text;
            //    string codigo = txtcodigo.Text;

            //    producto.registrar(marca, categoria, nombre, descripcion, precio, stock, caducidad,codigo);

            //    dgvproductos.DataSource = producto.listarActivos();
            //}
            ////limpiarcajas();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            dgvproductos.DataSource = producto.listarActivos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de eliminar?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadproducto.codigo = txtcodigo.Text;
                    //La entidad es enviada al metodo como parametro
                    if (producto.eliminar(entidadproducto) > 0)
                    {


                        //compartimientos postinseccion de datos
                        dgvproductos.DataSource = producto.listarActivos();

                        cargarmarcas();
                        cargarcategorias();
                        txtnombreproduc.Clear();
                        txtcodigo.Clear();
                        txtdescripcion.Clear();
                        txtprecio.Clear();
                        txtstock.Clear();
                        txtcodigo.Clear();
                        

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

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Primero la validación
            if (txtcodigo.Text.Trim() == String.Empty ||
                txtnombreproduc.Text.Trim() == String.Empty ||
                txtdescripcion.Text.Trim() == String.Empty||
                txtprecio.Text.Trim() == String.Empty ||
                txtstock.Text.Trim() == String.Empty ||
                dtpcaducidad.Text.Trim() == String.Empty ||
                cbcategoria.Text.Trim() == String.Empty ||
                cbmarca.Text.Trim() == String.Empty)
            {
                Dialogo.Informar("Seleccione un registro para hacer cambios");
            }
            else
            {
                if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
                {
                    //Enviar los valores de las cajas de texto a la entidad

                    entidadproducto.idmarca = Convert.ToString(cbmarca.SelectedValue);
                    entidadproducto.idcategoria = Convert.ToString(cbcategoria.SelectedValue);
                    entidadproducto.codigo = txtcodigo.Text.Trim();
                    entidadproducto.nombreproducto = txtnombreproduc.Text.Trim();
                    entidadproducto.descripcion = txtdescripcion.Text.Trim();
                    entidadproducto.precio = txtprecio.Text.Trim();
                    entidadproducto.stock = txtstock.Text.Trim();
                    entidadproducto.caducidad = dtpcaducidad.Text.Trim();
                    entidadproducto.idproducto = Convert.ToInt16(txtidproducto.Text);
                    //La entidad es enviada al metodo como parametro
                    if (producto.editar(entidadproducto) > 0)
                    {

                        //empresa.registrar(entidadEmpresa);

                        //compartimientos postinseccion de datos
                        dgvproductos.DataSource = producto.listarActivos();

                        cargarmarcas();
                        cargarcategorias();
                        txtnombreproduc.Clear();
                        txtcodigo.Clear();
                        txtdescripcion.Clear();
                        txtprecio.Clear();
                        txtstock.Clear();

                    }
                    else
                    {

                        Dialogo.Error("Error, no se pudo hacer cambios en el registro");
                    }
                }
            }
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproducto.Text = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dgvproductos.CurrentRow.Cells[1].Value.ToString();
            cbcategoria.Text = dgvproductos.CurrentRow.Cells[2].Value.ToString();
            txtnombreproduc.Text = dgvproductos.CurrentRow.Cells[3].Value.ToString();
            cbmarca.Text = dgvproductos.CurrentRow.Cells[4].Value.ToString();
            txtdescripcion.Text = dgvproductos.CurrentRow.Cells[5].Value.ToString();
            txtprecio.Text = dgvproductos.CurrentRow.Cells[6].Value.ToString();
            txtidproducto.Text = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            txtstock.Text = dgvproductos.CurrentRow.Cells[7].Value.ToString();
            dtpcaducidad.Text = dgvproductos.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
