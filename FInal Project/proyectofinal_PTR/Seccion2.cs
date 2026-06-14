using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Proyecto;

namespace proyectofinal_PTR
{
    public partial class Seccion2 : Form
    {
        private void limpiar()
        {
            txt_k1.Clear();
            txt_k2.Clear();
            txt_m1.Clear();
            txt_m2.Clear();
            txt_pos1.Clear();
            txt_vel1.Clear();
            txt_pos2.Clear();
            txt_vel2.Clear();
            txt_b.Clear();
        }

        public string RutaArchivo = Path.Combine(Application.StartupPath, "datos.txt");
        public string delimitador = ";";
        public string omitir = "<no aplica>";

        public void SubirDatos()
        {
            StreamWriter Escritor = new StreamWriter(RutaArchivo, true);
            Escritor.WriteLine(Menu_principal.nick + delimitador + txt_k1.Text + delimitador + txt_m1.Text + delimitador + txt_pos1.Text + delimitador + txt_vel1.Text + delimitador + txt_b.Text + delimitador + txt_k2.Text + delimitador + txt_m2.Text + delimitador + txt_pos2.Text + delimitador + txt_vel2.Text);
            Escritor.Close();
        }
        public void validar_texto(TextBox caja_texto, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                if (!caja_texto.Text.Contains("."))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public double[,] gauss_jordan(int fil, int col, double[,] matriz)
        {
            int i, j;
            if (matriz[0, 0] == 0)
            {
                for (int z = 0; z < col; z++)
                {
                    matriz[0, z] = matriz[0, z] + matriz[1, z];
                }
            }

            double[] diag = new double[col];
            double[] diag2 = new double[col];

            int count = 0;
            for (j = 0; j < col; j++)
            {
                for (i = 0; i < fil; i++)
                {
                    if (i != count && j < fil)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            diag[k] = Math.Abs(matriz[i, j]) * matriz[count, k];
                        }

                        for (int l = 0; l < col; l++)
                        {
                            diag2[l] = Math.Abs(matriz[count, count]) * matriz[i, l];
                        }
                        if (matriz[i, j] * matriz[count, count] < 0)
                        {
                            for (int h = 0; h < col; h++)
                            {
                                matriz[i, h] = diag2[h] + diag[h];
                            }
                        }
                        if (matriz[i, j] * matriz[count, count] > 0)
                        {
                            for (int h = 0; h < col; h++)
                            {
                                matriz[i, h] = diag2[h] - diag[h];
                            }
                        }
                    }
                }
                count += 1;
            }
            for (j = 0; j < fil; j++)
            {
                for (i = 0; i < fil; i++)
                {
                    if (i == j && j < col - 1)
                    {
                        for (int u = col - 1; u >= 0; u--)
                        {
                            matriz[i, u] = matriz[i, u] / matriz[i, i];
                        }
                    }
                    if (i == 0)
                    {
                        c1 = matriz[i, col - 1];
                    }
                    if (i == 1)
                    {
                        c2 = matriz[i, col - 1];
                    }
                }
            }
            return (matriz);
        }


        public Seccion2()
        {
            InitializeComponent();
        }

        Pen lapiz_masa = new Pen(Color.Black, 2);
        Arduino arduino = null;
        int caso, i=0, tref = 0;
        bool capturar = false;
        double c1, c2, alfa, wo, wd, lambda1, lambda2;
        double amplitud, desfase;

        private void txt_k1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_k1, e);
        }

        private void txt_k2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_k2, e);
        }

        private void txt_m1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_m1, e);
        }

        private void Seccion2_Load(object sender, EventArgs e)
        {
            string usuario = Menu_principal.usuario;
            string tipo_usuario = Menu_principal.tipo_usuario;
            arduino = Menu_principal.arduino;
            this.Text = usuario;
            this.Text = usuario;
            if (arduino == null)
            {
                txt_Tiempo.Enabled = false;
                txt_Tiempo.Text = "1";
            }
            if (arduino != null)
            {
                this.Text += " (Conectado con Arduino)";
            }
            if (tipo_usuario != "tipo1")
            {
                txt_b.Enabled = false;
                txt_k1.Enabled = false;
                txt_k2.Enabled = false;
                txt_m1.Enabled = false;
                txt_m2.Enabled = false;
                txt_pos1.Enabled = false;
                txt_pos2.Enabled = false;
                txt_vel1.Enabled = false;
                txt_vel2.Enabled = false;
                txt_b.Text = "1";
                txt_k1.Text = "1";
                txt_k2.Text = "1";
                txt_m1.Text = "1";
                txt_m2.Text = "1";
                txt_pos1.Text = "1";
                txt_pos2.Text = "1";
                txt_vel1.Text = "1";
                txt_vel2.Text = "1";
            }
        }

        private void lbl_vel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tiempoaplitud_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Tiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_m2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_m2, e);
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_b, e);
        }

        private void txt_pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_pos1, e);
        }

        private void txt_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_vel1, e);
        }

        private void btn_comenzar_Click(object sender, EventArgs e)
        {
            bool validar = true;
            TextBox[] datos = new TextBox[9];
            datos[0] = txt_k1;
            datos[1] = txt_k2;
            datos[2] = txt_m1;
            datos[3] = txt_m2;
            datos[4] = txt_pos1;
            datos[5] = txt_vel1;
            datos[6] = txt_pos2;
            datos[7] = txt_vel2;
            datos[8] = txt_b;
            for (int f = 0; f < 9; f++)
            {
                if (datos[f].Text == "")
                {
                    validar = false;
                }
            }
            if (validar == true)
            {
                int i, j, filas = 2, columnas = 3;
                double condicion;
                double[,] constantes = new double[filas, columnas];
                if (btn_comenzar.Text == "Pausa")
                {
                    lbl_tiempo.Visible = false;
                    timer1.Enabled = false;
                    btn_comenzar.Text = "Comenzar";
                    if (arduino != null)
                    {
                        txt_Tiempo.Enabled = true;
                        arduino.Apagar_Led();
                    }
                    txt_k1.Enabled = true;
                    txt_k2.Enabled = true;
                    txt_m1.Enabled = true;
                    txt_m2.Enabled = true;
                    txt_pos1.Enabled = true;
                    txt_pos2.Enabled = true;
                    txt_vel1.Enabled = true;
                    txt_vel2.Enabled = true;
                    txt_b.Enabled = true;
                    if (arduino != null)
                        txt_Tiempo.Enabled = true;
                }
                else
                {
                    btn_comenzar.Text = "Pausa";
                    txt_k1.Enabled = false;
                    txt_k2.Enabled = false;
                    txt_m1.Enabled = false;
                    txt_m2.Enabled = false;
                    txt_pos1.Enabled = false;
                    txt_pos2.Enabled = false;
                    txt_vel1.Enabled = false;
                    txt_vel2.Enabled = false;
                    txt_b.Enabled = false;
                    if (arduino != null)
                        txt_Tiempo.Enabled = false;
                    i = 0;
                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    chart3.Series[0].Points.Clear();
                    chart3.Series[1].Points.Clear();

                    //Inicio solucion de la parte acoplada

                    alfa = Convert.ToDouble(txt_b.Text) / (2 * Convert.ToDouble(txt_m1.Text));
                    wo = Math.Sqrt((Convert.ToDouble(txt_k1.Text) / Convert.ToDouble(txt_m1.Text)));
                    condicion = Math.Pow(alfa, 2) - Math.Pow(wo, 2);

                    //Sobreamortiguado
                    if (condicion > 0)
                    {
                        caso = 1;
                        lambda1 = -alfa + Math.Sqrt(condicion);
                        lambda2 = -alfa - Math.Sqrt(condicion);
                        for (i = 0; i < filas; i++)
                        {
                            for (j = 0; j < columnas; j++)
                            {
                                if (i == 0 && j < 2)
                                {
                                    constantes[i, j] = 1;
                                }
                                if (i == 0 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_pos1.Text);
                                }
                                if (i == 1 && j == 0)
                                {
                                    constantes[i, j] = lambda1;
                                }
                                if (i == 1 && j == 1)
                                {
                                    constantes[i, j] = lambda2;
                                }
                                if (i == 1 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_vel1.Text);
                                }
                            }
                        }
                    }
                    //Criticamente amortiguado
                    if (condicion == 0)
                    {
                        caso = 2;
                        for (i = 0; i < filas; i++)
                        {
                            for (j = 0; j < columnas; j++)
                            {
                                if (i == 0 && j == 0)
                                {
                                    constantes[i, j] = 0;
                                }
                                if (i == 0 && j == 1)
                                {
                                    constantes[i, j] = 1;
                                }
                                if (i == 0 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_pos1.Text);
                                }
                                if (i == 1 && j == 0)
                                {
                                    constantes[i, j] = 1;
                                }
                                if (i == 1 && j == 1)
                                {
                                    constantes[i, j] = -alfa;
                                }
                                if (i == 1 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_vel1.Text);
                                }
                            }
                        }
                    }
                    //Subamortiguado
                    if (condicion < 0)
                    {
                        caso = 3;
                        wd = Math.Sqrt(condicion * -1);
                        for (i = 0; i < filas; i++)
                        {
                            for (j = 0; j < columnas; j++)
                            {
                                if (i == 0 && j == 0)
                                {
                                    constantes[i, j] = 1;
                                }
                                if (i == 0 && j == 1)
                                {
                                    constantes[i, j] = 0;
                                }
                                if (i == 0 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_pos1.Text);
                                }
                                if (i == 1 && j == 0)
                                {
                                    constantes[i, j] = -alfa;
                                }
                                if (i == 1 && j == 1)
                                {
                                    constantes[i, j] = wd;
                                }
                                if (i == 1 && j == 2)
                                {
                                    constantes[i, j] = Convert.ToDouble(txt_vel1.Text); ;
                                }
                            }
                        }
                    }
                    //Calculo de las constantes
                    constantes = gauss_jordan(filas, columnas, constantes);



                    //inicio solucion parte simple

                    amplitud = Math.Sqrt(Math.Pow(Convert.ToDouble(txt_pos2.Text), 2) + Math.Pow(Convert.ToDouble(txt_vel2.Text) / wo, 2));
                    desfase = Math.Atan((Convert.ToDouble(txt_pos2.Text) * wo) / Convert.ToDouble(txt_vel2.Text));
                    i = 0;
                    if (arduino != null)
                        arduino.Apagar_Led();
                    capturar = false;
                    SubirDatos();
                    timer1.Enabled = true;

                }
                
            }
            else
            {
                DialogResult estado_datos;
                estado_datos = MessageBox.Show("No se han ingresado todos los datos","¡Advertencia!",MessageBoxButtons.OK);
                limpiar();
            }
        }

        private void Seccion2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_principal Carga = Owner as Menu_principal;
            Carga.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            double vel1 = 0, x1 = 0, x2 = 0, vel2 = 0, ec, ep, t;
            double frecuencia_angular=Math.Sqrt(Convert.ToDouble(txt_k2.Text) / Convert.ToDouble(txt_m2.Text));
            double x1real, vel1real, x2real, vel2real;
            i++;

            t = i/10.0;
            //Sobreamortiguado
            if (caso == 1)
            {
                x1 = c1 * Math.Exp(lambda1 * t) + c2 * Math.Exp(lambda2 * t);
                vel1 = c1 * lambda1 * Math.Exp(lambda1 * t) + c2 * lambda2 * Math.Exp(lambda2*t);
            }
            //Criticamente amortiguado
            if (caso == 2)
            {
                x1 = (i / 10) * c1 * Math.Exp(-alfa * t) + c2 * Math.Exp(-alfa * t);
                vel1 = c1 * Math.Exp(alfa * t) - t * c1 * alfa * Math.Exp(alfa * t) - c2 * alfa * Math.Exp(alfa * t);
            }
            //Subamortiguado
            if (caso == 3)
            {
                x1 = Math.Exp(-alfa * t) * (c1*Math.Cos(wd * t) + c2 * Math.Sin(wd * t));
                vel1 = -1 * alfa * Math.Exp(-alfa * t) * (c1 * Math.Cos(wd * t) + c2 * Math.Sin(wd * t)) + Math.Exp(-alfa * t) * (-c1 * wd * Math.Sin(wd * t) + c2 * wd * Math.Cos(wd * t));
            }
            //Parte simple
            x2 = amplitud * Math.Sin(frecuencia_angular*t+desfase);
            vel2 = amplitud * frecuencia_angular * Math.Cos(frecuencia_angular * t + desfase);

            x1real = 1 / Math.Sqrt(2.0) * (x1 + x2);
            x2real = 1 / Math.Sqrt(2.0) * (x2 - x1);
            vel1real = 1 / Math.Sqrt(2.0) * (vel1 + vel2);
            vel2real = 1 / Math.Sqrt(2.0) * (vel2 - vel1);

            ec = 1 / 2.0 * (Convert.ToDouble(txt_m1.Text)) * Math.Pow(vel1real, 2) + 1 / 2.0 * (Convert.ToDouble(txt_m2.Text)) * Math.Pow(vel2real, 2);
            ep = 1 / 2.0 * (Convert.ToDouble(txt_k1.Text)) * Math.Pow(x1real, 2) + 1 / 2.0 * (Convert.ToDouble(txt_k2.Text)) * Math.Pow(x2real, 2);

            if (arduino != null)
            {
                if (amplitud > Math.Sqrt(Math.Pow(Convert.ToDouble(txt_pos1.Text), 2) + Math.Pow(Convert.ToDouble(txt_pos1.Text), 2))/2 && !capturar)
                {
                    tref = i;
                    capturar = true;
                }
                if (i == tref + Convert.ToInt32(txt_Tiempo.Text))
                {
                    lbl_tiempo.Text = "LED encendido!";
                    lbl_tiempo.Visible = true;
                    arduino.Prender_Led();
                }
            }
                

            chart1.Series[0].Points.AddY(ec);
            chart2.Series[0].Points.AddY(ep);
            chart3.Series[0].Points.AddY(x1);
            chart3.Series[1].Points.AddY(x2);

            if (chart1.Series[0].Points.Count > 50)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart2.Series[0].Points.RemoveAt(0);
                chart3.Series[0].Points.RemoveAt(0);
                chart3.Series[1].Points.RemoveAt(0);
            }
        }


    }
}
