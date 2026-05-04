using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solucion_ejercicio4_taller3_PTR
{
    public partial class Form1 : Form
    {
        int count=0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double vol,di;
            bool proof=true;
            count++;

            if (string.IsNullOrEmpty(txt_alto.Text))
            {
                proof = false;
            }
            else if (string.IsNullOrEmpty(txt_largo.Text))
            {
                proof = false;
            }
            else if (string.IsNullOrEmpty(txt_ancho.Text))
            {
                proof = false;
            }

            if (proof == true)
            {
                if (count < 2)
                {
                    lbl_aviso.Text = "";
                    vol = Math.Ceiling(Convert.ToDouble(txt_ancho.Text) * Convert.ToDouble(txt_alto.Text) * Convert.ToDouble(txt_largo.Text));
                    bton_vol_dig.Text = "Calcular diagonales";
                    volu.Text = Convert.ToString(vol);
                }
                else
                {
                    di = Math.Ceiling(Math.Sqrt(Math.Pow(Convert.ToDouble(txt_ancho.Text), 2) + Math.Pow(Convert.ToDouble(txt_alto.Text), 2) + Math.Pow(Convert.ToDouble(txt_largo.Text), 2)));
                    diag.Text = Convert.ToString(di);
                    bton_reset.Visible = true;
                    bton_salir.Visible = true;
                    bton_vol_dig.Enabled = false;
                }
            }
            else
            {
                lbl_aviso.Text = "Ingrese valores validos";
                count = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            bton_vol_dig.Text = "Calcular Volumen";
            bton_reset.Visible = false;
            bton_salir.Visible = false;
            diag.Text = "";
            volu.Text = "";
            txt_ancho.Text = "";
            txt_alto.Text = "";
            txt_largo.Text = "";
            count = 0;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        

        

        
    }
}
