using EXAMEN_1HEMI.Controlador;
using EXAMEN_1HEMI.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_1HEMI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Listar();
        }

        public void Listar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;

            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = TListaBarcos.ListaBarcos;
                dataGridView1.Columns.Add(btnEditar);
                dataGridView1.Columns.Add(btnEliminar);
            }else if(comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = TlistaClientes.ListaClientes;
                dataGridView1.Columns.Add(btnEditar);
                dataGridView1.Columns.Add(btnEliminar);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = TListaAlquiler.ListaAlquiler;
                dataGridView1.Columns.Add(btnEditar);
                dataGridView1.Columns.Add(btnEliminar);
    
            }else if(comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = TListaSocios.ListaSocios;
                dataGridView1.Columns.Add(btnEditar);
                dataGridView1.Columns.Add(btnEliminar);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    if(dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        editarBarco(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    }
                    else if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el barco?", "Eliminar barco", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            TListaBarcos.EliminarBarco(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                            Listar();
                        }
                    }
                }else if(comboBox1.SelectedIndex == 1)
                {
                    if(dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        editarCliente(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    }else if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            TlistaClientes.EliminarCliente(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                            Listar();
                        }
                    }
                }else if(comboBox1.SelectedIndex == 2)
                {
                    if(dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        editarAlquiler(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    }else if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el alquiler?", "Eliminar alquiler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            TListaAlquiler.EliminarReporte(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                            Listar();
                        }
                    }
                }else if(comboBox1.SelectedIndex == 3)
                {
                    if(dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        editarSocio(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
                    }
                    else if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el socio?", "Eliminar socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            TListaSocios.EliminarSocio(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
                            Listar();
                        }
                    }
                }

            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                nuevoBarco();
            }else if(comboBox1.SelectedIndex == 1)
            {
                nuevoCliente();   
            }else if(comboBox1.SelectedIndex == 2)
            {
                nuevoAlquiler();
            }else if(comboBox1.SelectedIndex == 3)
            {
                nuevoSocio();
            }
        }

        public void nuevoCliente()
        {
            try
            {
                frmCliente frm = new frmCliente();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarCliente(string cedula)
        {
            try
            {
                frmCliente frm = new frmCliente();
                frm.Modo = "EDITAR";
                frm.Cedula = cedula;
                frm.setCliente(TlistaClientes.ObtenerCliente(cedula));
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nuevoAlquiler() {             
            try
            {
                frmAlquiler frm = new frmAlquiler();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarAlquiler(int id)
        {
            try
            {
                frmAlquiler frm = new frmAlquiler();
                frm.Modo = "EDITAR";
                frm.Id = id;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void nuevoBarco()
        {
            try
            {
                frmBarco frm = new frmBarco();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarBarco(int matricula)
        {
            try
            {
                frmBarco frm = new frmBarco();
                frm.Modo = "EDITAR";
                frm.NumeroMatricula = matricula;
                frm.setBarco(TListaBarcos.ObtenerBarco(matricula));
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editarSocio(string cedula) 
        {             
            try
            {
                frmSocio frm = new frmSocio();
                frm.Modo = "EDITAR";
                frm.Cedula = cedula;
                frm.setSocio(TListaSocios.ObtenerSocio(cedula));
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void nuevoSocio()
        {
            try
            {
                frmSocio frm = new frmSocio();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = TListaAlquiler.BarcoMasViajes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total recaudado: " + TListaAlquiler.TotalRecaudado());
        }
    }
}
