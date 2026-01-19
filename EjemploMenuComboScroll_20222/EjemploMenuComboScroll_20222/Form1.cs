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

namespace EjemploMenuComboScroll_20222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDato.Focus();
        }

        string RutaArchivoDatos = Path.Combine(Application.StartupPath, "Datos.txt");
        string RutaArchivoConsecutivoGrupo = Path.Combine(Application.StartupPath, "ConsecutivoGrupo.txt");

        int numGrupo = 1;
        List<string> Datos = new List<string>();
        string delimitador = "_";

        Graphics Papel;
        Pen LapizNegro = new Pen(Color.Black, 3);
        Pen LapizAzul = new Pen(Color.Blue, 4);
        Pen LapizRojo = new Pen(Color.Red, 2);
        Pen LapizBlanco = new Pen(Color.White, 5);

        Pen Lapiz = new Pen(Color.Black, 3);

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo uso Menu Scroll\nVersion 1.0\nPTR G1\nUniversidad Tecnologica de Pereira","Acerca de ...");
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string RutaPDFManualUsuario = Path.Combine(Application.StartupPath, "ManualUsuario.pdf");
                System.Diagnostics.Process.Start(RutaPDFManualUsuario);
            }
            catch 
            {
                MessageBox.Show("No se encontro el archivo requerido");
            }
        }

        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            if (lstDatosIngresados.Items.Count < 4)
            {
                if (txtDato.Text != string.Empty)
                {
                    lstDatosIngresados.Items.Add(txtDato.Text);
                    Datos.Add(cboGrupo.SelectedItem.ToString() + delimitador + txtDato.Text);

                    //almacenar en un archivo
                    //sobreescribir
                    StreamWriter escribir;
                    if (chkSobreescribir.Checked)
                    {
                        escribir = new StreamWriter(RutaArchivoDatos);
                    }
                    else
                    {
                        escribir = new StreamWriter(RutaArchivoDatos,true);
                    }
                    escribir.WriteLine(cboGrupo.SelectedItem.ToString() + delimitador + txtDato.Text);
                    escribir.Close();
                    txtDato.Text = string.Empty;
                    txtDato.Focus();
                }
            }
        }

        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !txtDato.Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txtDato.Text.Contains("."))
            {
                string[] textoDividido = txtDato.Text.Split('.');
                if (textoDividido[1].Length == 3)
                {
                    e.Handled = true;
                }
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnEliminarDato_Click(object sender, EventArgs e)
        {
            if (lstDatosIngresados.SelectedIndex > -1)
            {
                string cadena = lstDatosIngresados.SelectedItem.ToString();
                EliminarDatoArchivo();
                Datos.Remove(cboGrupo.SelectedItem.ToString()+delimitador+lstDatosIngresados.SelectedItem.ToString());
                lstDatosIngresados.Items.RemoveAt(lstDatosIngresados.SelectedIndex);
            }
            
        }

        void EliminarDatoArchivo()
        {
            List<string> DatosConservar = new List<string>();
            StreamReader leer = new StreamReader(RutaArchivoDatos);

            while (leer.Peek() > 0)
            {
                string linea = leer.ReadLine();
                string[] lineaDividida = linea.Split(Convert.ToChar(delimitador));
                if ((lineaDividida[0] == cboGrupo.Text) && (lstDatosIngresados.SelectedItem.ToString() == lineaDividida[1]))
                {
                    
                }
                else
                {
                    DatosConservar.Add(linea);
                }
            }

            leer.Close();

            //una vez clasificados los datos voy y sobreescribo el archivo con los que voy a conservar
            StreamWriter escribir = new StreamWriter(RutaArchivoDatos);
            foreach (string dato in DatosConservar)
            {
                escribir.WriteLine(dato);
            }
            escribir.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDato.Focus();

            Papel = pnlPapel.CreateGraphics();

            LeerConsecutivoGrupo();
            CargarGrupos();

            //foreach (SeriesChartType tipo in (SeriesChartType[])Enum.GetValues(typeof(SeriesChartType)))
            //{

            //    cboTipo.Items.Add(tipo.ToString());
            //}
        }

        void LeerConsecutivoGrupo()
        {
            StreamReader leer = new StreamReader(RutaArchivoConsecutivoGrupo);
            numGrupo = Convert.ToInt32(leer.ReadLine());
            leer.Close();
        }

        void CargarGrupos()
        {
            StreamReader leer = new StreamReader(RutaArchivoConsecutivoGrupo);
            numGrupo = Convert.ToInt32(leer.ReadLine());
            leer.Close();
            for (int i = 1; i < numGrupo; i++)
            {
                cboGrupo.Items.Add(i.ToString());
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtDato.Focus();
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            cboGrupo.Items.Add(numGrupo);
            cboGraficas.Items.Add(numGrupo);
            numGrupo++;

            StreamWriter escribir = new StreamWriter(RutaArchivoConsecutivoGrupo);
            escribir.WriteLine(numGrupo);
            escribir.Close();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDatosIngresados.Items.Clear();
            if (cboGrupo.SelectedIndex > -1)
            {
                pnlIngresoDatos.Enabled = true;
                //CargarDatos();
                CargarDatosArchivo();
            }
            else
                pnlIngresoDatos.Enabled = false;
        }

        public void CargarDatos()
        {
            if (Datos.Count > 0)
            {
                for (int i = 0; i < Datos.Count; i++)
                {
                    string[] linea = Datos[i].Split(Convert.ToChar(delimitador));
                    if (linea[0] == cboGrupo.SelectedItem.ToString())
                    {
                        lstDatosIngresados.Items.Add(linea[1]);
                    }
                }
            }
        }

        public void CargarDatosArchivo()
        {
            StreamReader leer = new StreamReader(RutaArchivoDatos);

            while (leer.Peek() > 0)
            {
                string linea = leer.ReadLine();
                string[] lineaDividida = linea.Split(Convert.ToChar(delimitador));
                if (lineaDividida[0] == cboGrupo.Text)
                {
                    lstDatosIngresados.Items.Add(lineaDividida[1]);
                }
            }

            leer.Close();
        }

        private void cboGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLeerFecha_Click(object sender, EventArgs e)
        {
            lblFechaSeleccionada.Text = dtpFecha.Value.Day.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Si cierra el formulario perdera la informacion!!! Esta seguro de cerrar el formulario?","Esta seguro?", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
 
            }
            else if (DialogResult.No == respuesta)
            {
                e.Cancel = true;
            }
        }

        private void cboGraficas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGraficas.SelectedIndex > -1)
            {
                //string prueba = chart1.Series.FindByName("Datos Grupo " + cboGraficas.SelectedItem.ToString()).ToString();
                if (!chart1.Series.Contains(chart1.Series.FindByName("Datos Grupo " + cboGraficas.SelectedItem.ToString())))
                {
                    chart1.Series.Add("Datos Grupo " + cboGraficas.SelectedItem.ToString());
                    chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()].ChartType = SeriesChartType.Line;
                    CargarDatosGrafico();
                }
            }
        }

        private void btnEliminarSerie_Click(object sender, EventArgs e)
        {
            if (cboGraficas.SelectedIndex > -1)
            {
                if (chart1.Series.Contains(chart1.Series.FindByName("Datos Grupo " + cboGraficas.SelectedItem.ToString())))
                {
                    chart1.Series.Remove(chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()]);
                }
            }
        }

        public void CargarDatosGrafico()
        {
            if (Datos.Count > 0)
            {
                for (int i = 0; i < Datos.Count; i++)
                {
                    string[] linea = Datos[i].Split(Convert.ToChar(delimitador));
                    if (linea[0] == cboGraficas.SelectedItem.ToString())
                    {
                        chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()].Points.AddY(Convert.ToDouble(linea[1]));
                    }
                }
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double datoMenor, datoMayor, promedio;
            double[] dato = new double[chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()].Points.Count];
            if (cboGraficas.SelectedIndex > -1)
            {
                for (int i=0; i<chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()].Points.Count;i++)
                {
                    dato[i]=Convert.ToDouble(chart1.Series["Datos Grupo " + cboGraficas.SelectedItem.ToString()].Points[i].YValues[0]);
                }
                datoMenor = dato.Min();
                datoMayor = dato.Max();
                promedio = dato.Average();
                txtValorMaximo.Text = datoMayor.ToString();
                txtValorMinimo.Text = datoMenor.ToString();
                txtPromedio.Text = promedio.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random numeroAleatorio = new Random();
            int numero = 0;
            numero = numeroAleatorio.Next(-100, 100);
            if (chart1.Series["Aleatoria"].Points.Count > 50)
                chart1.Series["Aleatoria"].Points.RemoveAt(0);
            chart1.Series["Aleatoria"].Points.AddY(numero);
            txtPromedio.Text = (Convert.ToInt32(txtPromedio.Text)+1).ToString();
        }

        private void btnGraficarAleatorio_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("Aleatoria");
            chart1.Series["Aleatoria"].ChartType = SeriesChartType.Line;
            timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDibujarLinea_Click(object sender, EventArgs e)
        {
            Papel.DrawLine(LapizNegro, 0, 0, pnlPapel.Width, pnlPapel.Height);
            Papel.DrawBezier(LapizAzul, 50, 40, 90, 55, 35, 110, 200, 145);
            Papel.DrawEllipse(LapizRojo, 100, 100, 80, 80);
        }

        int xAnte=0, yAnte=0;
        bool dibujar = false;
        bool linea=true;
        bool circulo=false;
        int x1Rec=0, y1Rec=0, x2Rec=0, y2Rec=0;
        private void pnlPapel_MouseMove(object sender, MouseEventArgs e)
        {
            
            Rectangle rec = new Rectangle();
            if (dibujar) {
                if (linea)
                {
                    Papel.DrawLine(Lapiz, xAnte, yAnte, e.X, e.Y);
                }
                xAnte = e.X;
                yAnte = e.Y;
                if (circulo)
                {
                    if (y2Rec != 0)
                    {
                        rec.X = x1Rec;
                        rec.Y = y1Rec;
                        rec.Width = x2Rec - x1Rec;
                        rec.Height = y2Rec - y1Rec;
                        Papel.DrawEllipse(Lapiz, rec);
                        x1Rec = y1Rec = y2Rec = x2Rec = 0;
                    }
                }
            }
            
            
        }       
        private void pnlPapel_MouseClick(object sender, MouseEventArgs e)
        {
            if (circulo)
            {
                dibujar = true;
                if (x1Rec == 0)
                {
                    x1Rec = e.X;
                    y1Rec = e.Y;
                }
                else
                {
                    x2Rec = e.X;
                    y2Rec = e.Y;
                }
            }
            if(linea)
            {
                if (yAnte == 0)
                {
                    xAnte = e.X;
                    yAnte = e.Y;
                }
                else
                {
                    xAnte = yAnte = 0;
                }
                if (e.Button == MouseButtons.Left)
                {
                    Lapiz = new Pen(Color.Black, 3);

                }
                else if ((e.Button == MouseButtons.Right))
                {
                    Lapiz = new Pen(Color.White, 5);
                }
                if (dibujar)
                dibujar = false;
            else
                dibujar = true;
            }
            
        }

        private void btnDibujarCirculo_Click(object sender, EventArgs e)
        {
            linea = false;
            circulo = true;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            linea = true;
            circulo = false;
        }

        private void btnBorrarPapel_Click(object sender, EventArgs e)
        {
            Papel.Clear(Color.White);
        }

    }
}
