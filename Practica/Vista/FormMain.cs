using Practica.Controlador;
using Practica.Entidades;
using Practica.Vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Practica
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            nuevaPersona();
        }

        public void nuevaPersona()
        {
            try
            {
                frmIngresoPersona frm = new frmIngresoPersona();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Persona obp = frm.crearPersona();
                    frm.Hide();
                    TLista.insert(obp);
                    MessageBox.Show("Persona creada");
                    listarPersonas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarPersonas()
        {
            var sql = from p in TLista.lista
                      select p;
            dataGridView1.DataSource = sql.ToList();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBuscarCompromiso frm = new frmBuscarCompromiso();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Cumpleaneros cumpleaneros = new Cumpleaneros();
            cumpleaneros.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void cargarDatos()
        {
            TLista.insert(new Persona("123456789", "Juan", "Perez", "Av. Boyaca", "1234567", new DateTime(1990, 1, 1), "Masculino", "Soltero"));
            TLista.insert(new Persona("987654321", "Maria", "Rodriguez", "Av. Boyaca", "1234567", new DateTime(1990, 1, 1), "Femenino", "Soltero"));
            TLista.insert(new Persona("123456789", "Juan", "Rodriguez", "Av. Boyaca", "123456754", new DateTime(1990, 1, 1), "Masculino", "Soltero"));
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Compromisos compromisos = new Compromisos();
            compromisos.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cargarDatos();
            listarPersonas();
        }
    }
}
