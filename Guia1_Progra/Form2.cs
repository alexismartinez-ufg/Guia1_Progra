using System.Windows.Forms;

namespace Guia1_Progra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string message)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(message))
                messageLbl.Text = message;
            else
                messageLbl.Text = "Por favor ingresa un nombre, gracioso...";
        }

        private void salirForm2Btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
