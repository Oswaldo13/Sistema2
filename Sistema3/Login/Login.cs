using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class Login : Form
    {
        public Login()
        {
            int O;
            InitializeComponent();
            InitializeComponent();
        }
        public bool logueado = false;
        private void button1_Click(object sender, EventArgs e)
        {

           
            logueado = true;
            if (logueado == true)
            {

                this.Visible = false;
                MessageBox.Show("Bienvendio Administrador", "Mensaje", MessageBoxButtons.OK);
                Inicial O = new Inicial();
                O.Show();

            }
            else
            {
                MessageBox.Show("El usuario o claves son incorrectos", "Error", MessageBoxButtons.OK);
                txtNombre.Text = "";
                txtContraseña.Text = "";
                txtNombre.Focus();


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
