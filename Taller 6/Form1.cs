using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ejercicio_taller6_PTR
{
    public partial class Form1 : Form
    {
        Graphics papel;
        Pen Lapizgeneral = new Pen(Color.Black, 2);
        Pen Lapiz_ejes = new Pen(Color.Black, 2);
        Pen Lapiz_elipse = new Pen(Color.Black,2);
        int x, y, j=0;
        string seccion2_tiempo;
        string seccion2_posicion;

        private void dibujar_ejes(Graphics papel, Pen lapiz)
        {
            papel.DrawLine(lapiz, 0, 0, 0, pnl_grafico.Height);
            papel.DrawLine(lapiz, 0, pnl_grafico.Height, pnl_grafico.Width, pnl_grafico.Height);
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

        public Form1()
        {
            InitializeComponent();
        }

        private static Word.Application aplicacion = null;
        private static Word.Document Libro = null;
        string ruta_datos = Path.Combine(Application.StartupPath, "datos_guardados.txt");
        string ruta_datos2 = Path.Combine(Application.StartupPath, "Manual de usuario.docx");
        string delimitador = "-";
        string delimitador2 = "_";


        private void Form1_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = DateTime.Now.ToString();
            txt_fecha.Enabled = false;
        }

        private void txt_tiempoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_tiempoin, e);
        }

        private void txt_tiempofi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_tiempofi, e);
        }

        private void txt_pos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_pos, e);
        }

        private void txt_vel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_vel, e);
        }

        private void txt_ace_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_ace, e);
        }

        private void txt_tiempopar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_tiempopar, e);
        }

        private void txt_pospar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_texto(txt_pospar, e);
        }

        private void nuevaSimulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            papel = pnl_grafico.CreateGraphics();
            txt_pos.Text = "";
            txt_vel.Text = "";
            txt_ace.Text = "";
            txt_tiempoin.Text = "";
            txt_tiempofi.Text = "";
            txt_pospar.Text = "";
            txt_tiempopar.Text = "";
            txt_mostrartiempo.Text = "";
            txt_mostrarposicion.Text = "";
            seccion2_posicion = "";
            seccion2_tiempo = "";
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
            timer1.Enabled = false;
            papel.Clear(Color.White);
            btn_simular2.Enabled = false;
            tabControl1.Visible = false;
            chart4.Visible = false;
            txt_fecha.Text = DateTime.Now.ToString();
            Lapizgeneral = new Pen(Color.Black, 2);
            Lapiz_ejes = new Pen(Color.Black, 2);
            Lapiz_elipse = new Pen(Color.Black, 2);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardado;
            guardado = MessageBox.Show("¿Esta seguro que desea guardar los datos de la simulacion actual?", "Guardar datos", MessageBoxButtons.OKCancel);
            if (guardado == DialogResult.OK)
            {
                StreamWriter guardar = new StreamWriter(ruta_datos);

                string sesion = txt_fecha.Text + delimitador + txt_pos.Text + delimitador + txt_vel.Text + delimitador + txt_ace.Text + delimitador + txt_tiempoin.Text + delimitador + txt_tiempofi.Text + delimitador + txt_tiempopar.Text + delimitador + txt_pospar.Text + delimitador + seccion2_tiempo + delimitador + seccion2_posicion;
                guardar.WriteLine(sesion);
                guardar.Close();
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            StreamReader cargar = new StreamReader(ruta_datos);
            TextBox[] texto = new TextBox[8];
            texto[0] = txt_fecha;
            texto[1] = txt_pos;
            texto[2] = txt_vel;
            texto[3] = txt_ace;
            texto[4] = txt_tiempoin;
            texto[5] = txt_tiempofi;
            texto[6] = txt_tiempopar;
            texto[7] = txt_pospar;

            string lineas = cargar.ReadLine();
            string[] textos = lineas.Split(Convert.ToChar(delimitador));
            for (i = 0; i < textos.Length - 2; i++)
            {
                texto[i].Text = textos[i].ToString();
            }

            seccion2_tiempo = textos[8].ToString();
            seccion2_posicion = textos[9].ToString();

            cargar.Close();

            string[] tempo = seccion2_tiempo.Split(Convert.ToChar(delimitador2));
            string[] poso = seccion2_posicion.Split(Convert.ToChar(delimitador2));

            for (i = 0; i < tempo.Length; i++)
            {
                txt_mostrartiempo.Text = txt_mostrartiempo.Text + "\r\n" + tempo[i];
                txt_mostrarposicion.Text = txt_mostrarposicion.Text + "\r\n" + poso[i];
            }
            btn_simular2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ancho = 10, alto = 10;
            papel.Clear(Color.White);
            dibujar_ejes(papel, Lapiz_ejes);
            papel.DrawLine(Lapizgeneral, 0, pnl_grafico.Height, x, y);
            papel.DrawEllipse(Lapiz_elipse, x, y-alto, ancho, alto);
            y=y-2;
            x=x+2;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lapiz_elipse= new Pen(Color.Green, 2);
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lapiz_elipse = new Pen(Color.Black, 2);
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lapiz_elipse = new Pen(Color.Red, 2);
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lapiz_elipse = new Pen(Color.Blue, 2);
        }

        private void verdeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lapizgeneral = new Pen(Color.Green, 2);
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lapizgeneral = new Pen(Color.Black, 2);
        }

        private void rojoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lapizgeneral = new Pen(Color.Red, 2);
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lapizgeneral = new Pen(Color.Blue, 2);
        }

        private void btn_simular2_Click(object sender, EventArgs e)
        {
            papel = pnl_grafico.CreateGraphics();
            timer1.Enabled = false;
            papel.Clear(Color.White);
            tabControl1.Visible = false;
            chart4.Visible = true;
            if (seccion2_posicion != "" && seccion2_tiempo != "")
            {

                string[] vector_tiempo = seccion2_tiempo.Split(Convert.ToChar(delimitador2));
                string[] vector_posicion = seccion2_posicion.Split(Convert.ToChar(delimitador2));


                for (int i = 0; i < vector_tiempo.Length; i++)
                {
                    chart4.Series[0].Points.AddXY(Convert.ToDouble(vector_tiempo[i]), Convert.ToDouble(vector_posicion[i]));
                }
            }
            else
            {
                DialogResult validar_1;
                validar_1 = MessageBox.Show("No se han ingresado datos", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btn_simular1_Click(object sender, EventArgs e)
        {
            bool validar = true;
            if (txt_tiempoin.Text == "")
            {
                validar = false;
            }
            if (txt_tiempofi.Text == "")
            {
                validar = false;
            }
            if (txt_pos.Text == "")
            {
                validar = false;
            }
            if (txt_vel.Text == "")
            {
                validar = false;
            }
            if (txt_ace.Text == "")
            {
                validar = false;
            }

            if (validar == true)
            {
                btn_continuar.Enabled = true;
                btn_pausar.Enabled = true;
                btn_menos.Enabled = true;
                btn_mas.Enabled = true;
                if (Convert.ToDouble(txt_tiempoin.Text) < 0 || Convert.ToDouble(txt_tiempofi.Text) < 0)
                {
                    DialogResult validar_negativo;
                    validar_negativo = MessageBox.Show("El tiempo no puede ser negativo", "ERROR", MessageBoxButtons.OK);

                    nuevaSimulacionToolStripMenuItem_Click(null, null);
                }
                else
                {
                    chart4.Visible = false;
                    tabControl1.Visible = true;

                    int i;
                    x = 0;
                    y = pnl_grafico.Height;
                    papel = pnl_grafico.CreateGraphics();
                    papel.DrawLine(Lapizgeneral, 0, pnl_grafico.Height, x, y);
                    dibujar_ejes(papel, Lapiz_ejes);
                    timer1.Enabled = true;

                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    chart3.Series[0].Points.Clear();

                    //Posicion
                    for (i = Convert.ToInt32(txt_tiempoin.Text); i < Convert.ToInt64(txt_tiempofi.Text); i++)
                    {
                        chart1.Series[0].Points.AddXY(Convert.ToDouble(i), Convert.ToDouble(txt_vel.Text) * i + Convert.ToDouble(txt_ace.Text) * i * i / 2 + Convert.ToDouble(txt_pos.Text));
                    }

                    //Velocidad
                    for (i = Convert.ToInt32(txt_tiempoin.Text); i < Convert.ToInt64(txt_tiempofi.Text); i++)
                    {
                        chart2.Series[0].Points.AddXY(Convert.ToDouble(i), Convert.ToDouble(txt_vel.Text) + Convert.ToDouble(txt_ace.Text) * i);
                    }

                    //Aceleracion
                    for (i = Convert.ToInt32(txt_tiempoin.Text); i < Convert.ToInt64(txt_tiempofi.Text); i++)
                    {
                        chart3.Series[0].Points.AddXY(Convert.ToDouble(i), Convert.ToDouble(txt_ace.Text));
                    }
                }
            }
            else
            {
                DialogResult validar_1;
                validar_1 = MessageBox.Show("No todos los parametros han sido ingresados", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btn_ponerpunto_Click(object sender, EventArgs e)
        {
            
            if (txt_pospar.Text != "" && txt_tiempopar.Text != "")
            {
                btn_simular2.Enabled = true;
                if (Convert.ToDouble(txt_pospar.Text) < 0)
                {
                    DialogResult validar_negativo;
                    validar_negativo = MessageBox.Show("El tiempo no puede ser negativo", "ERROR", MessageBoxButtons.OK);
                    txt_tiempopar.Text = "";
                    txt_pospar.Text = "";

                }
                else
                {
                    j++;

                    if (j == 1)
                    {
                        seccion2_tiempo = txt_tiempopar.Text;
                        seccion2_posicion = txt_pospar.Text;
                    }
                    else
                    {
                        seccion2_tiempo = seccion2_tiempo + delimitador2 + txt_tiempopar.Text;
                        seccion2_posicion = seccion2_posicion + delimitador2 + txt_pospar.Text;
                    }

                    txt_mostrartiempo.Text = txt_mostrartiempo.Text + "\r\n" + txt_tiempopar.Text;
                    txt_mostrarposicion.Text = txt_mostrarposicion.Text + "\r\n" + txt_pospar.Text;
                    txt_tiempopar.Text = "";
                    txt_pospar.Text = "";
                }
            }
            else
            {
                DialogResult validar;
                validar = MessageBox.Show("No todos los parametros han sido ingresados", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            if (timer1.Interval - 20 > 0)
            {
                timer1.Interval = timer1.Interval - 20;
            }

        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            if (timer1.Interval + 20 > 0)
            {
                timer1.Interval = timer1.Interval + 20;
            }
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aplicacion = new Word.Application();
            aplicacion.Visible = true;
            Libro = aplicacion.Documents.Open(ruta_datos2);
        }

        

    }
}
