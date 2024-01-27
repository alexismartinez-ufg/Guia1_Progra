using System.Windows.Forms;

namespace Analisis_Desarrollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            string nombre = $"{tbNombre.Text} {tbApellido.Text}";
            decimal salarioBruto;

            if (!decimal.TryParse(tbSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal porcentajeDescuento = 0;

            if (cbGerente.Checked)
                porcentajeDescuento = 20;
            else if (cbSubgerente.Checked)
                porcentajeDescuento = 15;
            else if (cbSecretaria.Checked)
                porcentajeDescuento = 5;

            decimal montoDescuento = salarioBruto * (porcentajeDescuento / 100);
            decimal salarioNeto = salarioBruto - montoDescuento;

            string mensaje = $"Nombre: {nombre}\n";
            mensaje += $"Tipo de empleado: {(cbGerente.Checked ? "Gerente" : (cbSubgerente.Checked ? "Subgerente" : "Secretaria"))}\n";
            mensaje += $"Salario bruto: {salarioBruto:C}\n";
            mensaje += $"Descuento ({porcentajeDescuento}%): {montoDescuento:C}\n";
            mensaje += $"Salario neto: {salarioNeto:C}";

            tbMontoDescuento.Text = montoDescuento.ToString("C");
            tbSalarioNeto.Text = salarioNeto.ToString("C");

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
