using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace LabFísica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        List<string> tiempos = new List<string>();
        string delimitador = "_";
        double tol, res;
        

        public void CargarDatos()
        {
            if (tiempos.Count > 0)
            {
                for (int i = 0; i < tiempos.Count; i++)
                {
                    string[] linea = tiempos[i].Split(Convert.ToChar(delimitador));
                    if (linea[0] == cboAlturas.SelectedItem.ToString())
                    {
                        lstTiempos.Items.Add(linea[1]);
                    }
                }
            }
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laboratorio de física 1, caída libre\nVersión PRE-Alpha-ante-0.0.1.0.3\nPTR G1\nUniversidad Tecnologica de Pereira", "Acerca de la aplicación");
        }

        private void btnAgregarAltura_Click(object sender, EventArgs e)
        {
            if ((cboAlturas.Text != string.Empty) && !cboAlturas.Items.Contains(cboAlturas.Text))
            {
                cboAlturas.Items.Add(cboAlturas.Text);
                cboAlturas2.Items.Add(cboAlturas.Text);
                cboAlturas.SelectedItem = cboAlturas.Text;
            }
                
            
        }
        private void btnAñadirDato_Click(object sender, EventArgs e)
        {
            //if (cboAlturas.SelectedItem == null)
            //{
            //    cboAlturas.SelectedIndex(0);
            //}

            if (cboAlturas.Items.Count > 0)
            {
                if (lstTiempos.Items.Count < 7)
                {
                    if (txtTiempo.Text != string.Empty)
                    {
                        lstTiempos.Items.Add(txtTiempo.Text);
                        tiempos.Add(cboAlturas.SelectedItem.ToString() + delimitador + txtTiempo.Text);

                        txtTiempo.Text = string.Empty;
                        txtTiempo.Focus();
                    }
                }
            }
            else
                MessageBox.Show("Párchala bro, no pusiste altura para ese tiempo =D", "Error por mindundi");

        }

        private void txtResolucion_TextChanged(object sender, EventArgs e)
        {
            if (txtResolucion.Text != string.Empty)
            res = Convert.ToDouble(txtResolucion.Text);
        }

        private void txtTolerancia_TextChanged(object sender, EventArgs e)
        {
            if (txtTolerancia.Text != string.Empty)
                tol = Convert.ToDouble(txtTolerancia.Text);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int vertical = 2;
            if (bobPicture.Location.Y + vertical + bobPicture.Size.Height < tabPage1.Height - 30)
            {
                bobPicture.Location = new Point(bobPicture.Location.X, bobPicture.Location.Y + vertical);
            }
            else
                bobPicture.Location = new Point(bobPicture.Location.X, 130);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int contador = 0;
            double[] dato = new double[tiempos.Count];
            double prom = 0, varianza = 0, desv = 0, B1 = 0, B2 = 0, A = 0, uc = 0, ug = 0, suma = 0, sumDesv = 0;
            
            if (tiempos.Count > 0)
            {
                for (int i = 0; i < tiempos.Count; i++)
                {
                    string[] linea = tiempos[i].Split(Convert.ToChar(delimitador));
                    if (linea[0] == cboAlturas2.SelectedItem.ToString())
                    {
                        dato[contador] = Convert.ToDouble(linea[1]);
                        contador++;
                    }
                }
                suma = dato.Sum();
                prom = suma / contador;
                txtProm.Text = prom.ToString();
                for (int i = 0; i < contador; i++)
                {
                    sumDesv = Math.Pow(dato[i] - prom, 2) + sumDesv;
                }
                desv = Math.Round(Math.Sqrt(sumDesv / contador),4);
                txtDesv.Text = desv.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboAlturas.SelectedItem = 1;
        }

        

        private void cboAlturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTiempos.Items.Clear();
            if (cboAlturas.SelectedIndex > -1)
            {
                pnlIngresoDatos.Enabled = true;
                CargarDatos();
            }
            else
                pnlIngresoDatos.Enabled = false;
        }
    }
}

