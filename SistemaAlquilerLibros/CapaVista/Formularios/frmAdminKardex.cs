using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capavista.Formularios
{
    public partial class frmAdminKardex : Form
    {
        public frmAdminKardex()
        {
            InitializeComponent();
            this.ln = new CapaLogica.Gestion.KardexLN();
            cargarCombo();
            Listar();
        }

        CapaLogica.Gestion.KardexLN ln;
        
        public void cargarCombo()
        {
            try
            {
                var libros = ln.LibrosCB();
                comboBox1.DataSource = new BindingSource(libros, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Listar()
        {
            try
            {
                dtgProducto.DataSource = ln.ListarKardex();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            try
            {
                frmKardex frm = new frmKardex();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    var kardex = frm.getKardex();
                    ln.InsertarKardex(kardex);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            try
            {
                if(dtgProducto.SelectedRows.Count > 0)
                {
                    frmKardex frm = new frmKardex();
                    frm.ShowDialog();
                    int id = Convert.ToInt32(dtgProducto.CurrentRow.Cells[0].Value);
                    frm.setDatos(id);
                    if(frm.DialogResult == DialogResult.OK)
                    {
                        var kardex = frm.getKardex();
                        kardex.Id_kardex = id;
                        ln.ModificarKardex(kardex);
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (dtgProducto.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dtgProducto.CurrentRow.Cells[0].Value);
                    ln.EliminarKardex(id);
                    Listar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
