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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_usuario.Clear();
            txt_documento.Clear();
            txt_correo.Clear();
            txt_contrasena.Clear();
            rbt_estandard.Checked=true;
            rbt_admin.Checked = false;
        }

        string RutaArchivo = Path.Combine(Application.StartupPath, "usuarios.txt");
        string delimitador = ";";

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            bool validar=true;
            int num_cajas = 5;
            TextBox[] validacion_texto = new TextBox[num_cajas];
            validacion_texto[0] = txt_nombre;
            validacion_texto[1] = txt_usuario;
            validacion_texto[2] = txt_documento;
            validacion_texto[3] = txt_correo;
            validacion_texto[4] = txt_contrasena;

            for (int i = 0; i < num_cajas; i++)
            {
                if (validacion_texto[i].Text == "")
                {
                    validar = false;
                }
            }

            if (validar == true)
            {
                StreamReader validar_usuario = new StreamReader(RutaArchivo);
                bool val_usuario = true;
                int cuentadmin = 0, cuenta_usuarios=0;
                string tipo_usu="";

                if (rbt_admin.Checked)
                {
                    tipo_usu = "tipo1";
                }
                if (rbt_estandard.Checked)
                {
                    tipo_usu="tipo2";
                }

                while (validar_usuario.Peek() > -1)
                {
                    string usuario = validar_usuario.ReadLine();
                    string[] datos_entrada = usuario.Split(Convert.ToChar(delimitador));
                    if (datos_entrada[0] != "")
                    {
                        if (datos_entrada[1] == "tipo1")
                        {
                            cuentadmin++;
                        }
                        if (datos_entrada[3] == txt_usuario.Text)
                        {
                            val_usuario = false;
                        }
                        cuenta_usuarios++;
                    }
                }
                validar_usuario.Close();

                if (cuentadmin >= 2 && rbt_admin.Checked)
                {
                    DialogResult estado_datos;
                    estado_datos = MessageBox.Show("Intente nuevamente", "Numero maximo de administradores alcanzado", MessageBoxButtons.OK);
                    limpiar();
                }

                else
                {
                    if (val_usuario == false)
                    {
                        DialogResult estado_usuario;
                        estado_usuario = MessageBox.Show("El usuario ya esta registrado", "¡Advertencia!", MessageBoxButtons.OK);
                        limpiar();
                    }
                    else
                    {
                        StreamWriter crear = new StreamWriter(RutaArchivo,true);
                        crear.Write(Convert.ToString(cuenta_usuarios+1)+delimitador+tipo_usu+delimitador+txt_nombre.Text+delimitador+txt_usuario.Text+delimitador+txt_documento.Text+delimitador+txt_correo.Text+delimitador+txt_contrasena.Text);
                        crear.Close();
                    }
                }
   
                
            }
            else
            {
                DialogResult estado_datos;
                estado_datos = MessageBox.Show("No se han ingresado todos los datos", "¡Advertencia!", MessageBoxButtons.OK);
                limpiar();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }

    }
}
