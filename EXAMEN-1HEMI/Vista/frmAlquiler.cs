using EXAMEN_1HEMI.Controlador;
using EXAMEN_1HEMI.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_1HEMI.Vista
{
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();
        }

        public string Modo { get; set; }
        public int Id { get; set; }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            listarBarcos();
            listarConductoresArrendatario();
            listarDestinos();
        }

        private void listarConductoresArrendatario()
        {
            cbConductor.Items.Clear();
            foreach (Cliente cliente in TlistaClientes.ListaClientes)
            {
                cbConductor.Items.Add(cliente.Cedula);
                cbArrendatario.Items.Add(cliente.Cedula);
            }
            foreach (Socio socio in TListaSocios.ListaSocios)
            {
                cbConductor.Items.Add(socio.Cedula);
                cbArrendatario.Items.Add(socio.Cedula);
            }
        }

        private void listarBarcos()
        {
            cbNumeroMatricula.Items.Clear();
            foreach (Barco barco in TListaBarcos.ListaBarcos)
            {
                cbNumeroMatricula.Items.Add(barco.NumeroMatricula);
            }
        }

        private void listarDestinos()
        {
            cbDestino.Items.Clear();
            foreach (KeyValuePair<string, double> destino in Destinos.DiccionarioDestino)
            {
                cbDestino.Items.Add(destino.Key);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Alquiler alquiler = crearAlquiler();
                    if(Modo == "EDITAR")
                    {
                        TListaAlquiler.ModificarAlquiler(alquiler, Id);
                        MessageBox.Show("Alquiler modificado correctamente");
                    }
                    else
                    {
                        TListaAlquiler.AgregarAlquiler(alquiler);
                        MessageBox.Show("Alquiler agregado correctamente");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Alquiler crearAlquiler()
        {
            Alquiler alquiler = new Alquiler();
            alquiler.Id = TListaAlquiler.ListaAlquiler.Count + 1;
            alquiler.CedulaArrendatario = cbArrendatario.SelectedItem.ToString();
            alquiler.CedulaConductor = cbConductor.SelectedItem.ToString();
            alquiler.NumeroMatricula = Convert.ToInt32(cbNumeroMatricula.SelectedItem.ToString());
            alquiler.FechaSalida = dateTimePicker1.Value;
            alquiler.Destino = cbDestino.SelectedItem.ToString();
            return alquiler;
        }

        private bool Validar()
        {
            bool ok = true;
            if(cbConductor.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Seleccione un conductor");
                cbConductor.Focus();
            }else if(cbNumeroMatricula.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Seleccione un barco");
                cbNumeroMatricula.Focus();
            }else if(cbDestino.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Seleccione un destino");
                cbDestino.Focus();
            }else if(dateTimePicker1.Value < DateTime.Now)
            {
                ok = false;
                MessageBox.Show("La fecha de salida no puede ser menor a la fecha actual");
                dateTimePicker1.Focus();
            }else if(dateTimePicker1.Value == null)
            {
                ok = false;
                MessageBox.Show("Seleccione una fecha de salida");
                dateTimePicker1.Focus();
            }

            Persona persona = TlistaClientes.ObtenerCliente(cbConductor.SelectedItem.ToString());
            if(persona == null)
            {
                persona = TListaSocios.ObtenerSocio(cbConductor.SelectedItem.ToString());
            }
            if(persona != null)
            {
                if(persona.Edad < 18)
                {
                    ok = false;
                    MessageBox.Show("Un menor de edad no puede alquilar");
                    cbArrendatario.Focus();
                }
            }

            return ok;

        }
    }
}
