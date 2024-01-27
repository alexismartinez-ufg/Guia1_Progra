using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Ejemplo2 : Form
    {
        public Ejemplo2()
        {
            InitializeComponent();
        }

        private void Ejemplo2_Load(object sender, EventArgs e)
        {
            listaBasicasCb.Items.Clear();
            listaBasicasCb.Items.Add("Sumar");
            listaBasicasCb.Items.Add("Restar");

            listaAvanzadasLb.Items.Clear();
            listaAvanzadasLb.Items.Add("Multiplicacion");
            listaAvanzadasLb.Items.Add("Division");
            listaAvanzadasLb.TabIndex = 0;

            listaBasicasCb.Enabled = false;
            listaAvanzadasLb.Enabled = false;

        }

        private void basicasRb_CheckedChanged(object sender, EventArgs e)
        {
            if (basicasRb.Checked)
            {
                listaBasicasCb.Enabled = true;
                listaAvanzadasLb.Enabled = false;
            }
        }

        private void avanzadaRb_CheckedChanged(object sender, EventArgs e)
        {
            if (avanzadaRb.Checked)
            {
                listaBasicasCb.Enabled = false;
                listaAvanzadasLb.Enabled = true;

                listaAvanzadasLb.SelectedIndex = 0;
            }
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(numero1Tb.Text);
            n2 = Convert.ToDouble(numero2Tb.Text);

            try
            {
                if (basicasRb.Checked)
                {
                    if (listaBasicasCb.SelectedItem.ToString() == "Sumar")
                        r = n1 + n2;
                    else
                        r = n1 - n2;

                    MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
                }
                else if (avanzadaRb.Checked)
                {
                    if (listaAvanzadasLb.SelectedItem.ToString() == "Multiplicacion")
                        r = n1 * n2;
                    else
                        r = n1 / n2;
                    MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parece que hubo un error!");
            }
        }
    }
}
