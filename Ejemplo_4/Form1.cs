using System;
using System.IO;
using System.Windows.Forms;

namespace Ejemplo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTxb.Text;
            string contra = contraseñaTxb.Text;

            string url = "C:\\LPN0\\" + usuario + ".txt"; 
            if (File.Exists(url)) 
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!");
                usuarioTxb.Clear();
                contraseñaTxb.Clear();
            }
            else
            {
                File.WriteAllText(url, contra); 
                MessageBox.Show("Usuario Registrado con éxito");
                usuarioTxb.Clear();
                contraseñaTxb.Clear();
            }
        }

        private void ingresoBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTxb.Text; 
            string contra = contraseñaTxb.Text;
            string url = "C:\\LPN0\\" + usuario + ".txt";
            if (File.Exists(url)) 
            {
                password = File.ReadAllText(url); 
                if (contra.Equals(password)) 
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!");
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! ");
            }

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string password;
    }
}
