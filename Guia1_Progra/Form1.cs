using System;
using System.Windows.Forms;

namespace Guia1_Progra
{
    public partial class Ejemplo1 : Form
    {
        public Ejemplo1()
        {
            InitializeComponent();
        }

        private void saveNameBtn_Click(object sender, EventArgs e)
        {
            var nombre = nameTB.Text;
            var message = string.Empty;

            if (!string.IsNullOrEmpty(nombre))
                message = $"Bienvenido {nombre} este es el segundo formulario";
            else
                message = "Por favor ingresa un nombre, gracioso...";

            //MessageBox.Show(message);

            var form2 = new Form2(message);

            form2.Visible = true;
            this.Visible = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
