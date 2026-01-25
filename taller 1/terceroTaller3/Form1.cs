using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace terceroTaller3
{
    
    public partial class Form1 : Form
    {   double clic=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void volumen_Click(object sender, EventArgs e)
        {
            double largo, ancho, alto;
            clic+=1;
            if (txtalto.Text != string.Empty && txtancho.Text != string.Empty && txtlargo.Text != string.Empty)
            { 
                largo = Convert.ToInt32(txtlargo.Text);
                ancho = Convert.ToInt32(txtancho.Text);
                alto = Convert.ToInt32(txtalto.Text);

                if(clic==1)
                {
                double v = ancho * alto * largo;
                lblvolumen.Text = Convert.ToString(v);
                volumen.Text = "Calcular la diagonal";
                }
                else if(clic==2)
                {
                    double diagonal = Math.Sqrt((ancho * ancho) + (largo * largo) + (alto * alto));
                    lblvolumen.Text = Convert.ToString(diagonal);
                    volumen.Enabled = false;
                }
            }
       }

        private void inicio_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
