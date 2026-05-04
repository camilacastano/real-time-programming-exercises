using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller3P3
{

    public partial class Form1 : Form
    {
        bool AreaC = false;
        bool AnchoC = false;

        public Form1()
        {
            InitializeComponent();
            BtnCalcular.Enabled = false;
            IngresoLargo.Text = string.Empty;
            IngresoArea.Text = string.Empty;
            IngresoAncho.Text = string.Empty;
        }

        private void IngresoLargo_TextChanged(object sender, EventArgs e)
        {
            if (IngresoLargo.Text == string.Empty)
            {
                BtnCalcular.Enabled = false;
            }
            else if (IngresoAncho.Text != String.Empty || IngresoAncho.Text != String.Empty)
                BtnCalcular.Enabled = true;
        }

        private void IngresoAncho_TextChanged(object sender, EventArgs e)
        {
            if (IngresoAncho.Text == string.Empty)
            {
                if (IngresoArea.Text == string.Empty)
                    BtnCalcular.Enabled = false;
                else if (IngresoArea.Text != string.Empty && IngresoLargo.Text != string.Empty)
                    BtnCalcular.Enabled = true;
            }
            else
            {
                AreaC = false;
                AnchoC = true;
                if (IngresoLargo.Text != string.Empty)
                    BtnCalcular.Enabled = true;
            }
        }

        private void IngresoArea_TextChanged(object sender, EventArgs e)
        {
            if (IngresoArea.Text == string.Empty)
            {
                if (IngresoAncho.Text == string.Empty)
                    BtnCalcular.Enabled = false;
                else if (IngresoAncho.Text != string.Empty && IngresoLargo.Text != string.Empty)
                    BtnCalcular.Enabled = true;
            }
            else
            {
                AreaC = true;
                AnchoC = false;
                if (IngresoLargo.Text != string.Empty)
                    BtnCalcular.Enabled = true;
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            IngresoLargo.Text = IngresoLargo.Text.Replace(" ", "");
            IngresoAncho.Text = IngresoLargo.Text.Replace(" ", "");
            IngresoArea.Text = IngresoLargo.Text.Replace(" ", "");
            if (IngresoLargo.Text.Contains("-"))
                IngresoLargo.Text = IngresoLargo.Text.Replace("-", "");
            if (IngresoLargo.Text.Contains("."))
                IngresoLargo.Text = IngresoLargo.Text.Replace(".", ",");
            if (IngresoArea.Text.Contains("-"))
                IngresoArea.Text = IngresoArea.Text.Replace("-", "");
            if (IngresoArea.Text.Contains("."))
                IngresoArea.Text = IngresoArea.Text.Replace(".", ",");
            if (IngresoAncho.Text.Contains("-"))
                IngresoAncho.Text = IngresoAncho.Text.Replace("-", "");
            if (IngresoAncho.Text.Contains("."))
                IngresoAncho.Text = IngresoAncho.Text.Replace(".", ",");
            if (AreaC)
            {
                IngresoAncho.Text = Convert.ToString((Convert.ToDouble(IngresoArea.Text) / Convert.ToDouble(IngresoLargo.Text))*1000);
                IngresoAncho.Text = Convert.ToString(Convert.ToDouble(Convert.ToInt32(Convert.ToDouble(IngresoAncho.Text))) / 1000);
            }
            if (AnchoC)
            {
                IngresoArea.Text = Convert.ToString((Convert.ToDouble(IngresoAncho.Text) * Convert.ToDouble(IngresoLargo.Text)) * 1000);
                IngresoArea.Text = Convert.ToString(Convert.ToDouble(Convert.ToInt32(Convert.ToDouble(IngresoArea.Text))) / 1000);
            }
            if (UnaIt.Checked)
            {
                IngresoLargo.Enabled = false;
                IngresoAncho.Enabled = false;
                IngresoArea.Enabled = false;
                BtnCalcular.Enabled = false;
                UnaIt.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnaIt.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnaIt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
