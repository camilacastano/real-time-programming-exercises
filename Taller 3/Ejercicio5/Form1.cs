using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        double A, B, C, R, raizmas, raizmenos;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);

            R = Math.Pow(B, 2) - 4 * A * C;

            if (R>0)
            {
                label7.Text = "Las raices son reales";
                raizmas = Math.Floor((-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                raizmenos = Math.Floor((-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                label5.Text = Convert.ToString(raizmas);
                label6.Text = Convert.ToString(raizmenos);
            }
            if (R < 0)
            {
                label7.Text = "Las raices son imaginarias";
                label5.Text = Convert.ToString(Math.Floor(-B / (2 * A))) + "+ i" + Convert.ToString(Math.Floor(Math.Sqrt(-Math.Pow(B, 2) + 4 * A * C) / (2 * A)));
                label6.Text = Convert.ToString(Math.Floor(-B/(2*A))) + "- i" + Convert.ToString(Math.Floor(Math.Sqrt(-Math.Pow(B, 2) + 4 * A * C) / (2 * A)));
            }
            if (R == 0)
            {
                label7.Text = "Las raices son iguales";
                raizmas = Math.Floor((-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                raizmenos = Math.Floor((-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                label5.Text = Convert.ToString(raizmas);
                label6.Text = Convert.ToString(raizmenos);
            }
       }
        }
    }