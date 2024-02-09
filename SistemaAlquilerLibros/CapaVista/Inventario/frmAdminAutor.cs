using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarketEcuador.Inventario
{
    public partial class frmAdminAutor : Form
    {
        public frmAdminAutor()
        {
            InitializeComponent();
        }
        //ProductoPersonalizadoLN oln = new ProductoPersonalizadoLN();
        //ProductoProveedorLN ppln = new ProductoProveedorLN();
        public void ListarProducto(string val)
        {
            //dtgProducto.DataSource = oln.ViewProductoPersonalizado(val);
        }
        private void frmAdminProducto_Load(object sender, EventArgs e)
        {
            ListarProducto(txtBuscar.Text);
        }
        /**public void Nuevo()
        {
            try
            {
                frmEditProducto  frmep = new frmEditProducto();
                frmep.Text = "Insertar Datos";
                frmep.lbingresar.Text = "Insertar Productos";
                frmep.ShowDialog();
                if (frmep.DialogResult == DialogResult.OK)
                {
                     Producto op = frmep.CrearObjetoProducto();
                     oln.CreateProducto(op);
                     ProductoProveedor opp = frmep.CrearObjetoProductoProveedor();
                     ppln.CreateProductoProveedor(opp);
                     frmep.Close();
                     lblEstado.Text = " Proveedor Insertado ";
                     ListarProducto(txtBuscar.Text);
                }


            }
            catch (Exception ex)
            {
                lblEstado.Text = " Error Insertar Proveedor " + ex.Message;
            }
        }*/

        /**public void Eliminar()
        {
            try
            {
                if (dtgProducto.CurrentRow != null)
                {
                    var res = MessageBox.Show("Desea eliminar producto", "Eliminar Producto", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        ProductoPersonalizado opp = dtgProducto.CurrentRow.DataBoundItem as ProductoPersonalizado;
                        Producto obp = dtgProducto.CurrentRow.DataBoundItem as Producto;
                        //ppln.DeleteProductoProveedor(opp);
                        
                        oln.DeleteProducto(obp);
                        ListarProducto(txtBuscar.Text);
                        lblEstado.Text = " Producto eliminado";
                    }
                    else
                        lblEstado.Text = " Eliminacion cancelada";

                }

                else
                    lblEstado.Text = " Selecciones la fila elimminar";

            }
            catch (Exception ex)
            {
                lblEstado.Text = " error al eliminar datos" + ex.Message;
            }
        }*/

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Eliminar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
