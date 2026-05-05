using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
              
            }

        }
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
           /* int Edad;
            try
            {
                Edad = Convert.ToInt32(textEdad.Text);//No me da :(
                if (Edad > 130)
                {
                    MessageBox.Show("Debe ingrear un valor menor de 130");
                }

            }
            catch
            {
                
            }*/
        }

        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
             else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            }

        private void btn1_Click(object sender, EventArgs e)
        {
            int Edad;
            try
            {
                Edad = Convert.ToInt32(textEdad.Text);
                if (Edad >= 18)
                {
                    tabControl1.SelectedIndex = 1;
                    MessageBox.Show("La persona es mayor de edad");

                }
                else 
                {
                    tabControl1.SelectedIndex = 1;
                   MessageBox.Show("La persona es menor de edad");
                }
            }
            catch 
            {
            }
            BorrarMensajesError();

            if (validarcampos())
            {
                //MessageBox.Show("Datos ingresados correctamente");
            }
      
        }
        private bool validarcampos()
        {
            bool ok = true;

            if (textNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textNombre, "Ingresar Nombre");
            }
            if (textEdad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textEdad, "Ingresar Edad");
            }
            if (textCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textCorreo, "Ingresar Correo");
            }
            return ok;
        }
        private void BorrarMensajesError()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textEdad, "");
            errorProvider1.SetError(textCorreo, "");
        }
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }


       private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {   
               tabControl1.SelectedIndex = 2;
            }
            catch
            {
              
            }
        }

       private void textEdad_TextChanged(object sender, EventArgs e)
       {
           if (textEdad.Text != string.Empty)
           {
               if (Convert.ToInt32(textEdad.Text) >= 130)
               {
                   MessageBox.Show("Debe ingrear un valor menor de 130");
                   textEdad.Text = "130";
               }
           }
       }

        }
    }
