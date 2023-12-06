using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace T2H1_EjerciciosFormularios
{
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(validarArtefacto() && validarCosto())
            {
                double costo = double.Parse(txtCosto.Text);
                double descuento = 0;
                double incremento = 0;
                double montoIGV = 0;

                if (chkContado.Checked)
                {
                    //Si el pago es al contado hay un descuento del 6% del costo del artefacto si el tipo de artefacto es Audio, 8 % si es Video y 5 % si es Línea Blanca
                    if (rbAudio.Checked)
                    {
                        descuento += costo * 0.06;
                    }
                    else if (rbVideo.Checked)
                    {
                        descuento += costo * 0.08;
                    }
                    else if (rbLinea.Checked)
                    {
                        descuento += costo * 0.05;
                    }
                }
                else
                {
                    //Si el pago es al crédito hay un incremento del 7% sobre el costo del artefacto si es el tipo de artefacto es Audio, 9 % si es Video y 10 % si es Línea Blanca
                    if (rbAudio.Checked)
                    {
                        incremento += costo * 0.07;
                    }
                    else if (rbVideo.Checked)
                    {
                        incremento += costo * 0.09;
                    }
                    else if (rbLinea.Checked)
                    {
                        incremento += costo * 0.1;
                    }
                }

                costo = costo - descuento + incremento;
                montoIGV = costo * 0.19;

                costo = costo + montoIGV;

                txtDescuento.Text = descuento.ToString();
                txtIncremento.Text = incremento.ToString();
                txtMontoIGV.Text = montoIGV.ToString();
                txtMontoPago.Text = costo.ToString();
            }   
        }

        private bool validarCosto()
        {
            double valor;
            if (txtCosto.Text != "" && double.TryParse(txtCosto.Text, out valor))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar una cantidad valida");
                txtCosto.Focus();
                return false;
            }
        }

        private bool validarArtefacto()
        {
            if (rbAudio.Checked || rbLinea.Checked || rbVideo.Checked)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artefacto");
                rbAudio.Focus();
                return false;
            }
        }   

        private void limpiar()
        {
            txtCosto.Text = "";
            txtDescuento.Text = "";
            txtIncremento.Text = "";
            txtMontoIGV.Text = "";
            txtMontoPago.Text = "";
            rbAudio.Checked = false;
            rbLinea.Checked = false;
            rbVideo.Checked = false;
            chkContado.Checked = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
