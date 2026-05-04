using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solucion_ejercicio2_taller3_PTR
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "Bienvenido: ";
            btn_eventoclick.Enabled = true;
            bton_reset.Visible = false;
            bton_salir.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_1.Text = "Evento click del boton";
            btn_eventoclick.Enabled = false;
            bton_reset.Visible = true;
            bton_salir.Visible = true;
        }
    }
}
