using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace solucion_ejercicio2_Taller4_PTR
{
    public partial class Triki : Form
    {
        int turnos=0;
        int[,] winner = new int[3,3];
        
        public Triki()
        {
            InitializeComponent();
        }

        private void desactivar_rbt()
        {
            rbtn_jug1.Checked = false;
            rbtn_jug2.Checked = false;
        }

        public int[,] matriz_puntuacion(int ent)
        {
            int[,] mattg = new int [3,3];
            int i,j;

            for (i=0;i<3;i++)
            {
              for(j=0;j<3;j++)
              {
                  mattg[i,j]=0;
              }
            }
            return (mattg);
        }

        public void inicializar_puntuacion()
        {
            if (turnos == 0)
            {
                winner = matriz_puntuacion(1);
            }
        }

        public void conteo_win(int i,int j)
        {
            if(rbtn_jug1.Checked==true)
            {
                winner[i,j]=1;
            }
            else if (rbtn_jug2.Checked == true)
            {
                winner[i, j] = 4;
            }
        }
    

        public Panel[,] matriz_juego(int ent)
        {
            Panel[,] mattp = new Panel [3,3];

            mattp[0, 0] = pnl_topl;
            mattp[0, 1] = pnl_topc;
            mattp[0, 2] = pnl_topr;

            mattp[1, 0] = pnl_centl;
            mattp[1, 1] = pnl_centc;
            mattp[1, 2] = pnl_centr;

            mattp[2, 0] = pnl_bottl;
            mattp[2, 1] = pnl_bottc;
            mattp[2, 2] = pnl_bottr;

            return (mattp);
        }

        private void camb_btn_jug()
        {
            if (rbtn_jug1.Checked == true)
            {
                rbtn_jug1.Checked = false;
                rbtn_jug2.Checked = true;
            }
            else if (rbtn_jug2.Checked == true)
            {
                rbtn_jug2.Checked = false;
                rbtn_jug1.Checked = true;
            }
        }

        public class puntuacion
        {
            public double porcentaje1, porcentaje2;
            public void subir_puntuacion(Label a)
            {
                int b;
                string vuelta;
                b = Convert.ToInt32(a.Text);
                b++; ;
                vuelta = Convert.ToString(b);
                a.Text = vuelta;
            }

            public void porcentaje_victorias(double jug1,double jug2,Label g1,Label g2)
            {
                if (jug1 != 0 || jug2 != 0)
                {
                    porcentaje1 = Math.Round(jug1 / (jug1 + jug2) * 100,2);
                    porcentaje2 = Math.Round((jug2 / (jug1 + jug2) * 100),2);
                    g1.Text = porcentaje1.ToString();
                    g2.Text = porcentaje2.ToString();
                }
            }
        }

        public void activar_juego(bool start, bool start2)
        {
            if (turnos == 0)
            {
                if (start == true || start2 == true)
                {
                    pnl_triki.Enabled = true;
                    lbl_activar.Text = "Juego Activado";
                    lbl_titulojug.Text = "";
                }
            }
        }

        private void bloquear_juego(Panel[,] pan)
        {
            int i, j;

            for (i = 0; i < 3; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    pan[i, j].Enabled = false;
                }
            }
        }

        //validaciones de ganador
        public int validar_horizontal(int[,] matriz_casilla)
        {
            int i, j, val, ganador=0;
            
            for (i = 0; i < 3; i++)
            {
                val = 0;
                for (j = 0; j < 3; j++)
                {
                    val = val + matriz_casilla[i, j];
                }
                if (val == 3)
                {
                    ganador = 1;
                }
                else if (val == 12)
                {
                    ganador = 2;
                }
            }
            return (ganador);
        }

        public int validar_vertical(int[,] matriz_casilla)
        {
            int i, j, val, ganador = 0;

            for (i = 0; i < 3; i++)
            {
                val = 0;
                for (j = 0; j < 3; j++)
                {
                    val = val + matriz_casilla[j, i];
                }
                if (val == 3)
                {
                    ganador = 1;
                }
                else if (val == 12)
                {
                    ganador = 2;
                }
            }
            return (ganador);
        }

        public int validar_diagonal(int[,] matriz_casilla)
        {
            int i, j, val, val2, ganador = 0;

            val = 0;
            val2 = 0;

            for (i = 0; i < 3; i++)
            {   
                for (j = 0; j < 3; j++)
                {
                    if (j + i == 2)
                    {
                        val2 = val2 + matriz_casilla[i, j];
                    }
                    if (j == i)
                    {
                        val = val + matriz_casilla[i, j];
                    }
                }  
            }
            if (val == 3 || val2 == 3)
            {
                ganador = 1;
            }
            else if (val == 12 || val2 == 12)
            {
                ganador = 2;
            }
            return (ganador);
        }

        public void validar_empate()
        {
            puntuacion empate=new puntuacion();
            if (turnos == 9)
            {
                empate.subir_puntuacion(lbl_numempa);
                btn_porcentaje.Enabled = true;
                desactivar_rbt();
            }
        }

        private void ultima_valid(Label lbl_prueba,Label lbl_mensaje, Panel[,] pnl_prueba,int num_prueba)
        {
            string jugador;
            puntuacion ganador = new puntuacion();
            jugador = Convert.ToString(num_prueba);
            ganador.subir_puntuacion(lbl_prueba);
            bloquear_juego(pnl_prueba);
            lbl_mensaje.Text = "Ha ganado el jugador "+jugador;
            btn_porcentaje.Enabled = true;
            desactivar_rbt();
        }

        public void victoria()
        {
            
            Panel[,] pan_game = new Panel[3, 3];
            int win1, win2, win3, seguro=0;

            pan_game = matriz_juego(1);

            win1 = validar_diagonal(winner);
            win2 = validar_horizontal(winner);
            win3 = validar_vertical(winner);

            if (win1 == 1)
            {
                ultima_valid(lbl_num1,lbl_titulojug,pan_game,win1);
                seguro = 1;
            }

            else if (win1 == 2)
            {
                ultima_valid(lbl_num2,lbl_titulojug, pan_game, win1);
                seguro = 1;
            }

            else if (win2 == 1)
            {
                ultima_valid(lbl_num1, lbl_titulojug, pan_game, win2);
                seguro = 1;
            }
            else if (win2 == 2)
            {
                ultima_valid(lbl_num2, lbl_titulojug, pan_game, win2);
                seguro = 1;
            }

            else if (win3 == 1)
            {
                ultima_valid(lbl_num1, lbl_titulojug, pan_game, win3);
                seguro = 1;
            }
            else if (win3 == 2)
            {
                ultima_valid(lbl_num2, lbl_titulojug, pan_game, win3);
                seguro = 1;
            }

            if (seguro == 0)
            {
                validar_empate();
            }
            
        }
        

        //Varios
        public void limpiar_casillas()
        {
            int i, j;
            Panel[,] nueva_matriz = new Panel[3, 3];
            nueva_matriz=matriz_juego(1);
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    nueva_matriz[i, j].BackColor = Color.White;
                    nueva_matriz[i, j].Enabled = true;
                }
            }
            
            pnl_triki.Enabled = false;
            lbl_activar.Text = "Juego Desactivado";
            lbl_titulojug.Text = "Seleccionar el jugador que empieza";
            desactivar_rbt();
            pnl_jugadores.Enabled = true;
            inicializar_puntuacion();
            turnos = 0;
            
        }

        private void cambiar_jugador()
        {
            if (rbtn_jug1.Checked == true)
            {
                rbtn_jug1.Checked = false;
                rbtn_jug2.Checked = true;
            }
            else if (rbtn_jug2.Checked == true)
            {
                rbtn_jug2.Checked = false;
                rbtn_jug1.Checked = true;
            }
        }


        private void marcar_casilla_jug(Panel pnl_prueba)
        {
            if (rbtn_jug2.Checked == true)
            {
                pnl_prueba.BackColor = Color.Blue;
            }
            else if (rbtn_jug1.Checked == true)
            {
                pnl_prueba.BackColor = Color.Black;
            }
            pnl_prueba.Enabled = false;
            turnos++;
        }

       //elementos
        private void btn_reset_Click(object sender, EventArgs e)
        {
            limpiar_casillas();
            btn_porcentaje.Enabled = false;
            lbl_num1.Text = "0";
            lbl_num2.Text = "0";
            lbl_numempa.Text = "0";
            lbl_porcentaje1.Text = "0";
            lbl_porcentaje2.Text = "0";
            inicializar_puntuacion();
        }
        
        //Superior
        private void pnl_topl_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_topl);
            conteo_win(0, 0);
            victoria();
            camb_btn_jug();
        }

        private void pnl_topc_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_topc);
            conteo_win(0, 1);
            victoria();
            camb_btn_jug();
        }

        private void pnl_topr_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_topr);
            conteo_win(0, 2);
            victoria();
            camb_btn_jug();
        }

        //central
        private void pnl_centl_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_centl);
            conteo_win(1, 0);
            victoria();
            camb_btn_jug();
        }

        private void pnl_centc_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_centc);
            conteo_win(1, 1);
            victoria();
            camb_btn_jug();
        }

        private void pnl_centr_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_centr);
            conteo_win(1, 2);
            victoria();
            camb_btn_jug();
        }


        //inferior

        private void pnl_bottl_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_bottl);
            conteo_win(2, 0);
            victoria();
            camb_btn_jug();
        }

        private void pnl_bottc_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_bottc);
            conteo_win(2, 1);
            victoria();
            camb_btn_jug();
        }

        private void pnl_bottr_Click(object sender, EventArgs e)
        {
            marcar_casilla_jug(pnl_bottr);
            conteo_win(2, 2);
            victoria();
            camb_btn_jug();
        }

        //interaccion jugador

        private void rbtn_jug1_CheckedChanged(object sender, EventArgs e)
        {
            activar_juego(rbtn_jug1.Checked, rbtn_jug2.Checked);
            pnl_jugadores.Enabled = false;
            inicializar_puntuacion();

        }

        private void rbtn_jug2_CheckedChanged(object sender, EventArgs e)
        {
            activar_juego(rbtn_jug1.Checked, rbtn_jug2.Checked);
            pnl_jugadores.Enabled = false;
            inicializar_puntuacion();
        }

        private void btn_limcas_Click(object sender, EventArgs e)
        {
            limpiar_casillas();
            lbl_titulojug.Text="Seleccionar el jugador que empieza";
        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {
            puntuacion porcentaje = new puntuacion();
            double a1, a2;
            a1 = Convert.ToDouble(lbl_num1.Text);
            a2 = Convert.ToDouble(lbl_num2.Text);

            porcentaje.porcentaje_victorias(a1, a2, lbl_porcentaje1, lbl_porcentaje2);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
