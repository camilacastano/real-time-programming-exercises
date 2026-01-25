using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace punto1Taller3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, EventArgs e)
        {
            if (click.Enabled)
            {
                click.Enabled = false;
                lblb.Text = "Evento click boton";
                inicio.Visible = true;
                cerrar.Visible = true;
            }

        }

        private void inicio_VisibleChanged(object sender, EventArgs e)
        {
            if (click.Enabled)
            {
                click.Enabled = true;
                inicio.Visible = false;
            }
           
        }

        private void cerrar_VisibleChanged(object sender, EventArgs e)
        {
            if (click.Enabled)
            {
                click.Enabled = true;
                cerrar.Visible = false;
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
