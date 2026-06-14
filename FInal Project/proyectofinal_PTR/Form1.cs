using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Proyecto;

namespace proyectofinal_PTR
{
    public partial class Menu_principal : Form
    {
        public static Arduino arduino = null;
        string RutaArchivo = Path.Combine(Application.StartupPath, "usuarios.txt");
        string delimitador = ";";

        public static string usuario = "";
        public static string nick = "";
        public static string tipo_usuario = "";

        public Menu_principal()
        {
            InitializeComponent();
        }

        private void bnn_ingresar_Click(object sender, EventArgs e)
        {
            StreamReader ingreso = new StreamReader(RutaArchivo);
            bool entrada = false;

            while (ingreso.Peek() > -1)
            {
                usuario = ingreso.ReadLine();
                if (usuario != "")
                {
                    string[] datos_entrada = usuario.Split(Convert.ToChar(delimitador));
                    if (datos_entrada[3] == txt_usuario.Text)
                    {
                        if (datos_entrada[6] == txt_constrasena.Text)
                        {
                            tipo_usuario = datos_entrada[1];
                            usuario = datos_entrada[2];
                            nick = datos_entrada[3];
                            entrada = true;
                            bnn_ingresar.Enabled = false;
                            break;
                        }  
                    }
                }

            }
            ingreso.Close();

            if (entrada == true)
            {
                DialogResult mensaje;
                mensaje = MessageBox.Show("Bienvenido", "Usuario Valido", MessageBoxButtons.OK);

                pnl_opciones.Visible = true;
                if (tipo_usuario == "tipo1")
                {
                    lbl_sec4.Visible = true;
                    btn_secc4.Visible = true;
                }
                txt_usuario.Enabled = false;
                txt_constrasena.Enabled = false;
            }
            else
            {
                DialogResult denegado;
                denegado = MessageBox.Show("Intente nuevamente", "Usuario o Contraseña no Validos", MessageBoxButtons.OK);

                txt_constrasena.Text = "";
                txt_usuario.Text = "";
            }
        }

        private void btn_nvou_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo_usuario = new NuevoUsuario();
            this.AddOwnedForm(nuevo_usuario);
            nuevo_usuario.Show();
            this.Hide();
        }

        private void btn_secc1_Click(object sender, EventArgs e)
        {
            Seccion1 seccion1 = new Seccion1();
            this.AddOwnedForm(seccion1);
            seccion1.Show();
            this.Hide();
        }

        private void btn_secc2_Click(object sender, EventArgs e)
        {
            Seccion2 seccion2 = new Seccion2();
            this.AddOwnedForm(seccion2);
            seccion2.Show();
            this.Hide();
        }

        private void btn_secc3_Click(object sender, EventArgs e)
        {
            Seccion3 seccion3 = new Seccion3();
            this.AddOwnedForm(seccion3);
            seccion3.Show();
            this.Hide();
        }

        private void btn_secc4_Click(object sender, EventArgs e)
        {
            if (tipo_usuario == "tipo1")
            {
                Seccion4 seccion4 = new Seccion4();
                this.AddOwnedForm(seccion4);
                seccion4.Show();
                this.Hide();
            }
            else
            {
                DialogResult denegado;
                denegado = MessageBox.Show("Intente nuevamente", "Usuario no admin.", MessageBoxButtons.OK);
            }
        }

        private void Menu_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (arduino != null)
                    arduino.Cerrar_Puerto();
            }
            catch
            {
            }
            Application.Exit();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboPuertos.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();

            foreach (string port in puertos)
            {
                cboPuertos.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPuertos.SelectedIndex != -1)
                btnConectar.Enabled = true;
            else
                btnConectar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cboPuertos.Items.Count > 0)
            {
                if (this.cboPuertos.SelectedIndex > -1)
                {
                    try
                    {

                        arduino = new Arduino(this.cboPuertos.Text, 115200); //Inicializamos arduino a 115200 bauds
                        arduino.Iniciar_Comunicacion();
                        label1.Text = "¡Conectado con Arduino!";
                        btnActualizar.Enabled = false;
                        btnConectar.Enabled = false;
                    }
                    catch
                    {
                        button2_Click(null, null);
                    }
                }
            }
        }
    }
}
