using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace proyectofinal_PTR
{
    public partial class Seccion1 : Form
    {
        public string RutaArchivo = Path.Combine(Application.StartupPath, "datos.txt");
        public string delimitador = ";";
        public string omitir = "<no aplica>";

        public void SubirDatos()
        {
            StreamWriter Escritor = new StreamWriter(RutaArchivo, true);
            Escritor.WriteLine(Menu_principal.nick + delimitador + txt_k.Text + delimitador + txt_m.Text + delimitador + txt_pos.Text + delimitador + txt_vel.Text + delimitador + omitir + delimitador + omitir + delimitador + omitir + delimitador + omitir + delimitador + omitir);
            Escritor.Close();
        }

        public double w, amplitud, fase, i = 0;
        Arduino arduino = null;
        public Seccion1()
        {
            InitializeComponent();
        }

        private void Seccion1_Load(object sender, EventArgs e)
        {
            string usuario = Menu_principal.usuario;
            string tipo_usuario = Menu_principal.tipo_usuario;
            arduino = Menu_principal.arduino;
            this.Text = usuario;
            if (arduino == null)
            {
                btn_Temp.Enabled = false;
            }
            if (arduino != null)
            {
                this.Text += " (Conectado con Arduino)";
            }
            if (tipo_usuario != "tipo1")
            {
                txt_k.Enabled = false;
                txt_m.Enabled = false;
                txt_pos.Enabled = false;
                txt_vel.Enabled = false;
                txt_k.Text = "1";
                txt_m.Text = "1";
                txt_pos.Text = "1";
                txt_vel.Text = "1";
            }
        }

        private void Seccion1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_principal Carga = Owner as Menu_principal;
            Carga.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Temp_Click(object sender, EventArgs e)
        {
            txt_k.Text = arduino.Tomar_Dato().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double x = 0, vel = 0, ec, ep, t;
            i++;
            t = i / 10;
            x = amplitud * Math.Cos(w * t+fase);
            vel = -amplitud*w * Math.Sin(w * t + fase);
            ec = 1 / 2.0 * (Convert.ToDouble(txt_m.Text)) * Math.Pow(vel, 2);
            ep = 1 / 2.0 * (Convert.ToDouble(txt_k.Text)) * Math.Pow(x, 2);
            chart1.Series[0].Points.AddY(ec);
            chart2.Series[0].Points.AddY(ep);
            chart3.Series[0].Points.AddY(x);
            if (chart1.Series[0].Points.Count > 50)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart2.Series[0].Points.RemoveAt(0);
                chart3.Series[0].Points.RemoveAt(0);
            }
        }

        private void btn_comenzar_Click(object sender, EventArgs e)
        {

            bool validar = true;
            TextBox[] datos = new TextBox[9];
            datos[0] = txt_k;
            datos[1] = txt_m;
            datos[2] = txt_pos;
            datos[3] = txt_vel;
            for (int f = 0; f < 4; f++)
            {
                if (datos[f].Text == "")
                {
                    validar = false;
                }
            }
            if (validar == true)
            {
                w = Math.Sqrt(Convert.ToDouble(datos[0].Text)/ Convert.ToDouble(datos[1].Text));
                amplitud = Convert.ToDouble(datos[2].Text);
                fase = Math.Atan(-Convert.ToDouble(datos[3].Text)/(w*Convert.ToDouble(datos[2].Text)));
                if (btn_comenzar.Text == "Pausa")
                {
                    timer1.Enabled = false;
                    btn_comenzar.Text = "Comenzar";
                    if (arduino != null)
                        btn_Temp.Enabled = true;
                    txt_k.Enabled = true;
                    txt_m.Enabled = true;
                    txt_pos.Enabled = true;
                    txt_vel.Enabled = true;
                }
                else
                {
                    btn_comenzar.Text = "Pausa";
                    txt_k.Enabled = false;
                    txt_m.Enabled = false;
                    txt_pos.Enabled = false;
                    txt_vel.Enabled = false;
                    amplitud = Convert.ToDouble(txt_pos.Text);
                    i = 0;
                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    chart3.Series[0].Points.Clear();
                    SubirDatos();
                    timer1.Enabled = true;
                }
                
            }
            else
            {
                DialogResult estado_datos;
                estado_datos = MessageBox.Show("No se han ingresado todos los datos", "¡Advertencia!", MessageBoxButtons.OK);
                txt_k.Clear();
                txt_m.Clear();
                txt_pos.Clear();
                txt_vel.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
