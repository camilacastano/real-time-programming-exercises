using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller4P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Texto.Font = new Font("Arial", 14, FontStyle.Regular);
            //RbtnLetras.Checked = true; //Siempre iniciia el formulario con el primer radiobutton ingresado activo.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 250);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RbtnLetras_CheckedChanged(object sender, EventArgs e)
        {
            Texto.Text = String.Empty;
        }

        private void RbtnNumeros_CheckedChanged(object sender, EventArgs e)
        {
            Texto.Text = String.Empty;
        }

        private void Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (RbtnLetras.Checked)
            {
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            if (RbtnNumeros.Checked)
            {
                if (Char.IsLetter(e.KeyChar))
                    e.Handled = true;
                else if (Char.IsPunctuation(e.KeyChar)) {
                    if (!Texto.Text.Contains(","))
                    {
                        if (!a.ToString().Contains("."))
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }
                else
                    e.Handled = false;
            }
        }

        public void Cambio()
        {
            if (ChkBold.Checked && ChkItalics.Checked && ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);
            if (ChkBold.Checked && ChkItalics.Checked && ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            if (ChkBold.Checked && ChkItalics.Checked && !ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            if (ChkBold.Checked && ChkItalics.Checked && !ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            if (ChkBold.Checked && !ChkItalics.Checked && ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline);
            if (ChkBold.Checked && !ChkItalics.Checked && ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Strikeout);
            if (ChkBold.Checked && !ChkItalics.Checked && !ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Underline);
            if (ChkBold.Checked && !ChkItalics.Checked && !ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold);
            if (!ChkBold.Checked && ChkItalics.Checked && ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);
            if (!ChkBold.Checked && ChkItalics.Checked && ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Strikeout);
            if (!ChkBold.Checked && ChkItalics.Checked && !ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Strikeout);
            if (!ChkBold.Checked && ChkItalics.Checked && !ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Italic);
            if (!ChkBold.Checked && !ChkItalics.Checked && ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            if (!ChkBold.Checked && !ChkItalics.Checked && ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            if (!ChkBold.Checked && !ChkItalics.Checked && !ChkStrikeout.Checked && ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Underline);
            if (!ChkBold.Checked && !ChkItalics.Checked && !ChkStrikeout.Checked && !ChkUnderlined.Checked)
                Texto.Font = new Font("Arial", 14, FontStyle.Regular);
        }

        private void Texto_TextChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void ChkItalics_CheckedChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void ChkUnderlined_CheckedChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void ChkStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            Cambio();
        }
    }
}
