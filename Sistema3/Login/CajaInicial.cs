﻿using System;
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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        public bool UsuarioLogueado = false;
        private void Menu_Load(object sender, EventArgs e)
        {
           



        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UsuarioLogueado== true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Salir De Eleventa", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(respuesta == DialogResult.No)
                {
                    e.Cancel = true;    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
