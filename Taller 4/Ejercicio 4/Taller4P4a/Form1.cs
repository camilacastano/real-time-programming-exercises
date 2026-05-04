using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller4P4a
{
    public partial class Form1 : Form
    {
        Caja Usuario = new Caja();
        public Form1()
        {
            InitializeComponent();
            DefinirSaldo.Checked = true;
            btnIng.Enabled = false;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ing1_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "1";
        }

        private void Ing2_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "2";
        }

        private void Ing3_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "3";
        }

        private void Ing4_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "4";
        }

        private void Ing5_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "5";
        }

        private void Ing6_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "6";
        }

        private void Ing7_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "7";
        }

        private void Ing8_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "8";
        }

        private void Ing9_Click(object sender, EventArgs e)
        {
            CajaIng.Text += "9";
        }

        private void Ing0_Click(object sender, EventArgs e)
        {
            if (CajaIng.Text != "0")
                CajaIng.Text += "0";
        }

        private void Ing00_Click(object sender, EventArgs e)
        {
            if (CajaIng.Text != "0" && CajaIng.Text != String.Empty)
                CajaIng.Text += "00";
            if (CajaIng.Text == String.Empty)
                CajaIng.Text += "0";
        }

        private void IngComa_Click(object sender, EventArgs e)
        {
            if (CajaIng.Text != String.Empty)
            {
                if (!(CajaIng.Text.Contains(",")))
                    CajaIng.Text += ",";
            }
        }

        private void SuprAll_Click(object sender, EventArgs e)
        {
            CajaIng.Text = String.Empty;
        }

        private void Supr_Click(object sender, EventArgs e)
        {
            if (CajaIng.Text != String.Empty)
                CajaIng.Text = CajaIng.Text.Remove(CajaIng.Text.Length - 1, 1);
        }

        private void DefinirSaldo_CheckedChanged(object sender, EventArgs e)
        {
            AdvSaldo.Visible = false;
            AdvExceso.Visible = false;
            Retirar.Visible = false;
            TexIngresos.Visible = false;
            ValIngresos.Visible = false;
            TexEgresos.Visible = false;
            ValEgresos.Visible = false;
            Lista.Items.Clear();
            VPagoCliente.Visible = false;
            VPago.Visible = false;
            VDevuCliente.Visible = false;
            VDevu.Visible = false;
            Usuario.Sum = 0;
            DefinirSaldo.Enabled = false;
            PreSaldo.Visible = false;
            TextoSaldo.Visible = false;
            IngresoPrecio1.Visible = false;
            IngresoPrecio2.Visible = false;
            Lista.Visible = false;
            Quitar.Visible = false;
            Facturar.Visible = false;
            PreTotal.Visible = false;
            PagoNoPosible.Visible = false;
            Pagar.Visible = false;
            AdvPago.Visible = false;
            Pagar.Visible = false;
            PreTotal.ForeColor = Color.Maroon;
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            Usuario.ValorIngresado = Convert.ToDouble(CajaIng.Text);
            if (DefinirSaldo.Checked) // Se ingresa el saldo inicial (o de la caja)
            {
                DefinirSaldo.Checked = false;
                if (Usuario.PermitirSaldo(Usuario.ValorIngresado))
                {
                    AdvSaldo.Visible = false;
                    Quitar.Enabled = false;
                    Facturar.Enabled = false;
                    DefinirSaldo.Enabled = true;
                    Usuario.Saldo = Usuario.ValorIngresado;
                    PreSaldo.Text = "$ " + Usuario.Saldo;
                    TextoSaldo.Visible = true;
                    PreSaldo.Visible = true;
                    IngresoPrecio1.Visible = true;
                    IngresoPrecio2.Visible = true;
                    Lista.Visible = true;
                    Lista.Enabled = true;
                    Quitar.Visible = true;
                    Facturar.Visible = true;
                }
                else
                {
                    DefinirSaldo.Checked = true;
                    AdvSaldo.Text = "Saldo ingresado no válido, Intente de nuevo.";
                    AdvSaldo.Visible = true;
                }
            }
            else
            {
                if (PreTotal.ForeColor == Color.Maroon) //Se ingresan los valores de compra
                {
                    VPagoCliente.Visible = false;
                    VPago.Visible = false;
                    VDevuCliente.Visible = false;
                    VDevu.Visible = false;
                    PagoNoPosible.Visible = false;
                    Pagar.Visible = false;
                    AdvPago.Visible = false;
                    Usuario.SumaProductos(Usuario.ValorIngresado);
                    Lista.Items.Add("$ " + Usuario.ValorIngresado);
                    PreTotal.Visible = true;
                    PreTotal.Text = "Total: $ " + Usuario.Sum;
                    Quitar.Enabled = true;
                    Facturar.Enabled = true;
                }
                if (PreTotal.ForeColor == Color.Aqua) // Se ingresa el valor de devuelta
                {

                    VDevuCliente.Visible = true;
                    VDevu.Text = "";
                    VDevu.Visible = true;
                    Usuario.Devuelta = Usuario.ValorIngresado - Usuario.Sum;
                    VDevu.Text = "$ " + Usuario.Devuelta;
                    VPago.Text = "$ " + Usuario.ValorIngresado;
                    Usuario.ValorPago = Usuario.ValorIngresado;
                    if ((Usuario.PosiblePago(Usuario.ValorPago) && Usuario.ValorPago >= Usuario.Sum) || Usuario.Devuelta == 0)
                    {
                        Pagar.Visible = true;
                    }
                    else
                    {
                        AdvPago.Visible = true;
                        if (Usuario.ValorPago < Usuario.Sum)
                            PagoNoPosible.Text = "No se puede efectuar el pago.";
                        else
                            PagoNoPosible.Text = "No hay saldo suficiente para devolver.";
                        PagoNoPosible.Visible = true;
                        Lista.Enabled = true;
                        PreTotal.ForeColor = Color.Maroon;
                        Quitar.Enabled = true;
                        Facturar.Enabled = true;
                    }
                }
            }
            CajaIng.Text = String.Empty;
        }

        private void CajaIng_TextChanged(object sender, EventArgs e)
        {
            if (CajaIng.Text == String.Empty)
                btnIng.Enabled = false;
            else
                btnIng.Enabled = true;
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            VPagoCliente.Visible = false;
            VPago.Visible = false;
            VDevuCliente.Visible = false;
            VDevu.Visible = false;
            PagoNoPosible.Visible = false;
            Pagar.Visible = false;
            AdvPago.Visible = false;
            Pagar.Visible = false;
            if (!(Lista.SelectedIndex == -1))
            {
                Usuario.QuitaProductos(Convert.ToDouble(Convert.ToString(Lista.Items[Lista.SelectedIndex]).Replace("$ ", "")));
                Lista.Items.RemoveAt(Lista.SelectedIndex);
                PreTotal.Text = "Total: $ " + Usuario.Sum;
            }
            if (Lista.Items.Count == 0)
            {
                Quitar.Enabled = false;
                Facturar.Enabled = false;
                PreTotal.Visible = false;
            }
        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            Lista.Enabled = false;
            Quitar.Enabled = false;
            Facturar.Enabled = false;
            Pagar.Visible = false;
            PagoNoPosible.Visible = false;
            AdvPago.Visible = false;
            PreTotal.ForeColor = Color.Aqua;
            VPago.Text = "<Ingrese el valor con el que el usuario paga>";
            VPagoCliente.Visible = true;
            VPago.Visible = true;
            VDevuCliente.Visible = false;
            VDevu.Text = "";
            VDevu.Visible = false;
        }

        private void Pagar_Click(object sender, EventArgs e) //Cuando se hace el pago, se debe analizar si ya se ha superado el tope
        {
            Usuario.Sum = 0;
            Pagar.Visible = false;
            PreTotal.Text = String.Empty;
            Lista.Items.Clear();
            Lista.Enabled = true;
            VPagoCliente.Visible = false;
            VPago.Visible = false;
            VDevuCliente.Visible = false;
            VDevu.Visible = false;
            PreTotal.ForeColor = Color.Maroon;
            Usuario.EfectuarPago(Usuario.Devuelta, Usuario.ValorPago);//Egresos: Valores retirados una vez superado el tope.
            PreSaldo.Text = "$ " + Usuario.Saldo;
            if (Usuario.Saldo > 200000)
            {
                AdvExceso.Visible = true;
                Retirar.Visible = true;
            }
            else
            {
                AdvExceso.Visible = false;
                Retirar.Visible = false;
            }
            ValIngresos.Text = "$ " + Usuario.Ingresos;
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            AdvExceso.Visible = false;
            Retirar.Visible = false;
            Usuario.Egresos += Usuario.Saldo - 30000;
            Usuario.Saldo = 30000;
            ValEgresos.Text = "$ " + Usuario.Egresos;
            PreSaldo.Text = "$ " + Usuario.Saldo;
        }

        private void ValIngresos_TextChanged(object sender, EventArgs e)
        {
            if (ValIngresos.Text != String.Empty)
            {
                TexIngresos.Visible = true;
                ValIngresos.Visible = true;
            }
            else
            {
                TexIngresos.Visible = false;
                ValIngresos.Visible = false;
            }
        }

        private void ValEgresos_TextChanged(object sender, EventArgs e)
        {
            if (ValEgresos.Text != String.Empty)
            {
                TexEgresos.Visible = true;
                ValEgresos.Visible = true;
            }
            else
            {
                TexEgresos.Visible = false;
                ValEgresos.Visible = false;
            }
        }

        private void PreTotal_TextChanged(object sender, EventArgs e)
        {
            if (Usuario.Sum == 0)
                PreTotal.Visible = false;
        }

    }
}
