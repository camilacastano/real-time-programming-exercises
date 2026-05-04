using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        int horizontal, vertical;
        public Form1()
        {
            InitializeComponent();
            vertical = 7; //vertical move pxl
            horizontal = 7;
        }
        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pnlCursor.Location.Y - vertical > 0) //no pasa lim
            {
                pnlCursor.Location = new Point(pnlCursor.Location.X, pnlCursor.Location.Y - vertical);
            }

        }    // repetir proceso        

       
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pnlCursor.Location.Y + pnlCursor.Size.Height + vertical < pnlPrueba.Height)
            {
                pnlCursor.Location = new Point(pnlCursor.Location.X, pnlCursor.Location.Y + vertical);
            }
            
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pnlCursor.Location.X - horizontal > 0)
            {
                pnlCursor.Location = new Point(pnlCursor.Location.X - horizontal, pnlCursor.Location.Y);
            }
            
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pnlCursor.Location.X + pnlCursor.Width + horizontal <  pnlPrueba.Width)
            {
                pnlCursor.Location = new Point(pnlCursor.Location.X + horizontal, pnlCursor.Location.Y);
            }
                  
        }

        private void btn_anchoplus_Click(object sender, EventArgs e)
        {
            pnlCursor.Width=pnlCursor.Width+2;
        }

        private void btn_altoplus_Click(object sender, EventArgs e)
        {
            pnlCursor.Height = pnlCursor.Height + 2;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}    


