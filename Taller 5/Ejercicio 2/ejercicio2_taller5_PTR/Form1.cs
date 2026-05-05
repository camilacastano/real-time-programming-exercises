using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2_taller5_PTR
{
    public partial class Form1 : Form
    {
        private void quitar_fecha()
        {
            btn_okdtp.Visible = false;
            dtp_fecha.Visible = false;
        }

        private void quitar_tamletra()
        {
            btn_ok.Visible = false;
            hsb_sizeletra.Visible = false;
            lbl_tamletra.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp2;
            resp2 = MessageBox.Show("¿Esta seguro que desea generar un nuevo texto?", "Alerta", MessageBoxButtons.YesNo);
            if (resp2 == DialogResult.OK)
            {
                txt_textoingresado.Text = "";
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp=MessageBox.Show("El ultimo texto guardado se borrara ¿Desea guardar el texto?", "Alerta", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                txt_sololectura.Text = txt_textoingresado.Text;
                txt_sololectura.Font = txt_textoingresado.Font;
            }
        }


        private void modificarTamañoLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitar_fecha();
            hsb_sizeletra.Visible = true;
            lbl_tamletra.Visible = true;
            btn_ok.Visible = true;

        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitar_tamletra();

            btn_okdtp.Visible = true;
            dtp_fecha.Visible = true;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            quitar_tamletra();
        }

        private void btn_okdtp_Click(object sender, EventArgs e)
        {
            quitar_fecha();

            string fecha;

            fecha = dtp_fecha.Value.ToString("MM-dd-yyyy");
            txt_textoingresado.Text = fecha + "\r\n" + txt_textoingresado.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbl_tamletra.Text = hsb_sizeletra.Value.ToString();
        }

        private void hsb_sizeletra_Scroll(object sender, ScrollEventArgs e)
        {
            int valor;
            float valorfl;
            valor = hsb_sizeletra.Value;
            valorfl = valor;
            Font font = new Font("Microsoft Sans Serif", valorfl);

            txt_textoingresado.Font = font;

            lbl_tamletra.Text = hsb_sizeletra.Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

 

    }
}
