using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solucion_ejercicio1_Taller3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_acciones_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "Se ha presionado click";
        }

        private void btn_acciones_MouseLeave(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "El mouse ha dejado el boton";
        }

        private void btn_acciones_MouseEnter(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "El mouse ha entrado al boton";
        }

        private void btn_acciones_MouseHover(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "El mouse esta flotando sobre el boton";
        }
    }
}
