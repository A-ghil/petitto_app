﻿using System;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Excluir : Form
    {
        public Tela_Excluir()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            app_controller.excluirUsuarioPorId(textBox1.Text);
        }
    }
}