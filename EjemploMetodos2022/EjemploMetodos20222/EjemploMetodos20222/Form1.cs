using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploMetodos20222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public enum Operaciones
        {
            suma=0, 
            resta = 1,
            multiplicacion=67,
            division,
        }

        private void btnEnumeracion_Click(object sender, EventArgs e)
        {
            lblEnumeracion.Text = Operaciones.division.ToString() +"   "+  Convert.ToInt32(Operaciones.division);
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dato1, dato2, multiplica, divide;
            if (txtDato1.Text != string.Empty && txtDato2.Text != string.Empty)
            {
                dato1 = Convert.ToInt32(txtDato1.Text);
                dato2 = Convert.ToInt32(txtDato2.Text);

                if (rbtnSuma.Checked)
                {
                    Sumar(dato1, dato2);
                    int suma=dato1+dato2;
                    lstHistorial.Items.Add(dato1.ToString() + " + " + dato2.ToString() + "=" + suma.ToString());
                    if (lstHistorial.Items.Count == 5)
                    {
                        lstHistorial.Items.RemoveAt(0);
                        
                    }
                }
                else if (rbtnResta.Checked)
                {
                    lblResultado.Text = Restar(dato1, dato2);
                    lstHistorial.Items.Add(dato1.ToString() + " - " + dato2.ToString() + "=" + lblResultado.Text);
                    if (lstHistorial.Items.Count == 5)
                    {
                        lstHistorial.Items.RemoveAt(0);
                        
                    }
                }
                else if (chkMultiplicacion.Checked)
                {
                    MultplicarDividir(dato1, dato2, out multiplica, out divide);
                    lblResultado.Text ="La multiplicacion " + multiplica.ToString() + " , la division " + divide.ToString();
                    lstHistorial.Items.Add(dato1.ToString() + " * " + dato2.ToString() + "=" + multiplica.ToString());
                    if (lstHistorial.Items.Count == 5)
                    {
                        lstHistorial.Items.RemoveAt(0);
                        
                    }
                    lstHistorial.Items.Add(dato1.ToString() + " / " + dato2.ToString() + "=" + divide.ToString());
                    if (lstHistorial.Items.Count == 5)
                    {
                        lstHistorial.Items.RemoveAt(0);
                        
                    }
                }
                else
                {
                    lblResultado.Text = "Defina la operacion a realizar";
                }
            }
            else
            {
                lblResultado.Text = "Ingrese los datos";
            }
        }

        public void Sumar(int d1, int d2)
        {
            int suma = 0;
            suma = d1 + d2;
            lblResultado.Text = suma.ToString();
        }

        public string Restar(int d1, int d2)
        {
            int resta = 0;
            resta = d1 - d2;
            return (resta.ToString());
        }

        public void MultplicarDividir(int d1, int d2, out int multiplicacion, out int division)
        {
            int multi, divi=0;
            multi = d1 * d2;
            multiplicacion = multi;
            if(d2!=0)
                divi = d1 / d2;
            division = divi;
        }

        private void chkMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultiplicacion.Checked)
            {
                rbtnSuma.Checked = false;
                rbtnResta.Checked = false;
                chkDivision.Checked = true;
            }
            else
            {
                chkDivision.Checked = false;
            }
        }

        private void rbtnSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSuma.Checked)
            {
                chkDivision.Checked = false;
                chkMultiplicacion.Checked = false;
            }
        }

        private void rbtnResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnResta.Checked)
            {
                chkDivision.Checked = false;
                chkMultiplicacion.Checked = false;
            }
        }

        private void chkDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDivision.Checked)
            {
                rbtnSuma.Checked = false;
                rbtnResta.Checked = false;
                chkMultiplicacion.Checked = true;
            }
            else
            {
                chkMultiplicacion.Checked = false;
            }
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = lstHistorial.SelectedItem.ToString();
            string [] operacionDividida = seleccion.Split('=');

            if (operacionDividida[0].Contains("+"))
            {
                string[] operacionDividida2 = operacionDividida[0].Split('+');
                txtDato1.Text= operacionDividida2[0].Trim();
                txtDato2.Text = operacionDividida2[1].Trim();
                rbtnSuma.Checked = true;
            }
            
        }

        private void txtDato1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !txtDato1.Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCalcularClase_Click(object sender, EventArgs e)
        {
            Calculadora[] calculo1 = new Calculadora[50];
            calculo1[0] = new Calculadora();
          
            if (txtDato1.Text != string.Empty && txtDato2.Text != string.Empty)
            {
                calculo1[0].dato1 = Convert.ToInt32(txtDato1.Text);
                calculo1[0].dato2 = Convert.ToInt32(txtDato2.Text);

                if (rbtnSuma.Checked)
                {
                    lblResultado.Text = calculo1[0].Sumar().ToString();
                }
                else if (rbtnResta.Checked)
                {
                    
                }
                else if (chkMultiplicacion.Checked)
                {
                    
                }
                else
                {
                    lblResultado.Text = "Defina la operacion a realizar";
                }
            }
            else
            {
                lblResultado.Text = "Ingrese los datos";
            }
        }

        



    }
}
