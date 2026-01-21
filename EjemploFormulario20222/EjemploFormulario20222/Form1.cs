using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploFormulario20222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            float
            int edad;
            if (txtEdad.Text != string.Empty)
            {
                edad = Convert.ToInt32(txtEdad.Text);
                if (edad >= 18)
                {
                    lblMensaje.Text = "La persona es mayor de edad.";
                }
                else
                {
                    lblMensaje.Text = "La persona es menor de edad.";
                }
            }
            else
            {
                lblMensaje.Text = "Debe ingresar informacion.";
            }
        }

        private void bntCalcular_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bntCalcular_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void bntCalcular_MouseEnter(object sender, EventArgs e)
        {
            //Random numAleatorio = new Random();
            //btnCalcular.Location = new Point(numAleatorio.Next(0,300), 100);
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != string.Empty)
                btnCalcular.Enabled = true;
            else
                btnCalcular.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
        }
    }
}
