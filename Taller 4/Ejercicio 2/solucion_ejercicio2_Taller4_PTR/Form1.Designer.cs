namespace solucion_ejercicio2_Taller4_PTR
{
    partial class Triki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_vict = new System.Windows.Forms.Label();
            this.lbl_jug1 = new System.Windows.Forms.Label();
            this.lbl_jug2 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.rbtn_jug1 = new System.Windows.Forms.RadioButton();
            this.rbtn_jug2 = new System.Windows.Forms.RadioButton();
            this.pnl_contador = new System.Windows.Forms.Panel();
            this.lbl_porcentaje2 = new System.Windows.Forms.Label();
            this.lbl_porcentaje1 = new System.Windows.Forms.Label();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.lbl_numempa = new System.Windows.Forms.Label();
            this.lbl_empa = new System.Windows.Forms.Label();
            this.pnl_topl = new System.Windows.Forms.Panel();
            this.pnl_topc = new System.Windows.Forms.Panel();
            this.pnl_topr = new System.Windows.Forms.Panel();
            this.pnl_centl = new System.Windows.Forms.Panel();
            this.pnl_centc = new System.Windows.Forms.Panel();
            this.pnl_centr = new System.Windows.Forms.Panel();
            this.pnl_bottl = new System.Windows.Forms.Panel();
            this.pnl_bottc = new System.Windows.Forms.Panel();
            this.pnl_bottr = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_triki = new System.Windows.Forms.Panel();
            this.lbl_activar = new System.Windows.Forms.Label();
            this.pnl_jugadores = new System.Windows.Forms.Panel();
            this.btn_limcas = new System.Windows.Forms.Button();
            this.lbl_titulojug = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_porcentaje = new System.Windows.Forms.Button();
            this.pnl_contador.SuspendLayout();
            this.pnl_triki.SuspendLayout();
            this.pnl_jugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_vict
            // 
            this.lbl_vict.AutoSize = true;
            this.lbl_vict.Location = new System.Drawing.Point(15, 42);
            this.lbl_vict.Name = "lbl_vict";
            this.lbl_vict.Size = new System.Drawing.Size(50, 13);
            this.lbl_vict.TabIndex = 0;
            this.lbl_vict.Text = "Victorias:";
            // 
            // lbl_jug1
            // 
            this.lbl_jug1.AutoSize = true;
            this.lbl_jug1.Location = new System.Drawing.Point(81, 12);
            this.lbl_jug1.Name = "lbl_jug1";
            this.lbl_jug1.Size = new System.Drawing.Size(54, 13);
            this.lbl_jug1.TabIndex = 1;
            this.lbl_jug1.Text = "Jugador 1";
            // 
            // lbl_jug2
            // 
            this.lbl_jug2.AutoSize = true;
            this.lbl_jug2.Location = new System.Drawing.Point(166, 12);
            this.lbl_jug2.Name = "lbl_jug2";
            this.lbl_jug2.Size = new System.Drawing.Size(54, 13);
            this.lbl_jug2.TabIndex = 2;
            this.lbl_jug2.Text = "Jugador 2";
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(106, 42);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(13, 13);
            this.lbl_num1.TabIndex = 3;
            this.lbl_num1.Text = "0";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(187, 42);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(13, 13);
            this.lbl_num2.TabIndex = 4;
            this.lbl_num2.Text = "0";
            // 
            // rbtn_jug1
            // 
            this.rbtn_jug1.AutoSize = true;
            this.rbtn_jug1.Location = new System.Drawing.Point(19, 15);
            this.rbtn_jug1.Name = "rbtn_jug1";
            this.rbtn_jug1.Size = new System.Drawing.Size(72, 17);
            this.rbtn_jug1.TabIndex = 5;
            this.rbtn_jug1.TabStop = true;
            this.rbtn_jug1.Text = "Jugador 1";
            this.rbtn_jug1.UseVisualStyleBackColor = true;
            this.rbtn_jug1.CheckedChanged += new System.EventHandler(this.rbtn_jug1_CheckedChanged);
            // 
            // rbtn_jug2
            // 
            this.rbtn_jug2.AutoSize = true;
            this.rbtn_jug2.Location = new System.Drawing.Point(116, 15);
            this.rbtn_jug2.Name = "rbtn_jug2";
            this.rbtn_jug2.Size = new System.Drawing.Size(72, 17);
            this.rbtn_jug2.TabIndex = 6;
            this.rbtn_jug2.TabStop = true;
            this.rbtn_jug2.Text = "Jugador 2";
            this.rbtn_jug2.UseVisualStyleBackColor = true;
            this.rbtn_jug2.CheckedChanged += new System.EventHandler(this.rbtn_jug2_CheckedChanged);
            // 
            // pnl_contador
            // 
            this.pnl_contador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_contador.Controls.Add(this.lbl_porcentaje2);
            this.pnl_contador.Controls.Add(this.lbl_porcentaje1);
            this.pnl_contador.Controls.Add(this.lbl_porcentaje);
            this.pnl_contador.Controls.Add(this.lbl_numempa);
            this.pnl_contador.Controls.Add(this.lbl_empa);
            this.pnl_contador.Controls.Add(this.lbl_num2);
            this.pnl_contador.Controls.Add(this.lbl_num1);
            this.pnl_contador.Controls.Add(this.lbl_jug2);
            this.pnl_contador.Controls.Add(this.lbl_vict);
            this.pnl_contador.Controls.Add(this.lbl_jug1);
            this.pnl_contador.Location = new System.Drawing.Point(12, 41);
            this.pnl_contador.Name = "pnl_contador";
            this.pnl_contador.Size = new System.Drawing.Size(234, 132);
            this.pnl_contador.TabIndex = 7;
            // 
            // lbl_porcentaje2
            // 
            this.lbl_porcentaje2.AutoSize = true;
            this.lbl_porcentaje2.Location = new System.Drawing.Point(187, 99);
            this.lbl_porcentaje2.Name = "lbl_porcentaje2";
            this.lbl_porcentaje2.Size = new System.Drawing.Size(13, 13);
            this.lbl_porcentaje2.TabIndex = 17;
            this.lbl_porcentaje2.Text = "0";
            // 
            // lbl_porcentaje1
            // 
            this.lbl_porcentaje1.AutoSize = true;
            this.lbl_porcentaje1.Location = new System.Drawing.Point(106, 99);
            this.lbl_porcentaje1.Name = "lbl_porcentaje1";
            this.lbl_porcentaje1.Size = new System.Drawing.Size(13, 13);
            this.lbl_porcentaje1.TabIndex = 16;
            this.lbl_porcentaje1.Text = "0";
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(15, 99);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(60, 13);
            this.lbl_porcentaje.TabIndex = 16;
            this.lbl_porcentaje.Text = "% victorias:";
            // 
            // lbl_numempa
            // 
            this.lbl_numempa.AutoSize = true;
            this.lbl_numempa.Location = new System.Drawing.Point(150, 68);
            this.lbl_numempa.Name = "lbl_numempa";
            this.lbl_numempa.Size = new System.Drawing.Size(13, 13);
            this.lbl_numempa.TabIndex = 15;
            this.lbl_numempa.Text = "0";
            // 
            // lbl_empa
            // 
            this.lbl_empa.AutoSize = true;
            this.lbl_empa.Location = new System.Drawing.Point(15, 68);
            this.lbl_empa.Name = "lbl_empa";
            this.lbl_empa.Size = new System.Drawing.Size(51, 13);
            this.lbl_empa.TabIndex = 15;
            this.lbl_empa.Text = "Empates:";
            // 
            // pnl_topl
            // 
            this.pnl_topl.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_topl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_topl.Location = new System.Drawing.Point(59, 38);
            this.pnl_topl.Name = "pnl_topl";
            this.pnl_topl.Size = new System.Drawing.Size(25, 25);
            this.pnl_topl.TabIndex = 8;
            this.pnl_topl.Click += new System.EventHandler(this.pnl_topl_Click);
            // 
            // pnl_topc
            // 
            this.pnl_topc.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_topc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_topc.Location = new System.Drawing.Point(90, 38);
            this.pnl_topc.Name = "pnl_topc";
            this.pnl_topc.Size = new System.Drawing.Size(25, 25);
            this.pnl_topc.TabIndex = 9;
            this.pnl_topc.Click += new System.EventHandler(this.pnl_topc_Click);
            // 
            // pnl_topr
            // 
            this.pnl_topr.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_topr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_topr.Location = new System.Drawing.Point(121, 38);
            this.pnl_topr.Name = "pnl_topr";
            this.pnl_topr.Size = new System.Drawing.Size(25, 25);
            this.pnl_topr.TabIndex = 10;
            this.pnl_topr.Click += new System.EventHandler(this.pnl_topr_Click);
            // 
            // pnl_centl
            // 
            this.pnl_centl.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_centl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_centl.Location = new System.Drawing.Point(60, 69);
            this.pnl_centl.Name = "pnl_centl";
            this.pnl_centl.Size = new System.Drawing.Size(25, 25);
            this.pnl_centl.TabIndex = 9;
            this.pnl_centl.Click += new System.EventHandler(this.pnl_centl_Click);
            // 
            // pnl_centc
            // 
            this.pnl_centc.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_centc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_centc.Location = new System.Drawing.Point(91, 69);
            this.pnl_centc.Name = "pnl_centc";
            this.pnl_centc.Size = new System.Drawing.Size(25, 25);
            this.pnl_centc.TabIndex = 9;
            this.pnl_centc.Click += new System.EventHandler(this.pnl_centc_Click);
            // 
            // pnl_centr
            // 
            this.pnl_centr.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_centr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_centr.Location = new System.Drawing.Point(122, 69);
            this.pnl_centr.Name = "pnl_centr";
            this.pnl_centr.Size = new System.Drawing.Size(25, 25);
            this.pnl_centr.TabIndex = 11;
            this.pnl_centr.Click += new System.EventHandler(this.pnl_centr_Click);
            // 
            // pnl_bottl
            // 
            this.pnl_bottl.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_bottl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottl.Location = new System.Drawing.Point(60, 100);
            this.pnl_bottl.Name = "pnl_bottl";
            this.pnl_bottl.Size = new System.Drawing.Size(25, 25);
            this.pnl_bottl.TabIndex = 12;
            this.pnl_bottl.Click += new System.EventHandler(this.pnl_bottl_Click);
            // 
            // pnl_bottc
            // 
            this.pnl_bottc.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_bottc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottc.Location = new System.Drawing.Point(91, 100);
            this.pnl_bottc.Name = "pnl_bottc";
            this.pnl_bottc.Size = new System.Drawing.Size(25, 25);
            this.pnl_bottc.TabIndex = 13;
            this.pnl_bottc.Click += new System.EventHandler(this.pnl_bottc_Click);
            // 
            // pnl_bottr
            // 
            this.pnl_bottr.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_bottr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_bottr.Location = new System.Drawing.Point(122, 100);
            this.pnl_bottr.Name = "pnl_bottr";
            this.pnl_bottr.Size = new System.Drawing.Size(25, 25);
            this.pnl_bottr.TabIndex = 14;
            this.pnl_bottr.Click += new System.EventHandler(this.pnl_bottr_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(10, 200);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(122, 23);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Resetear Puntuacion";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // pnl_triki
            // 
            this.pnl_triki.Controls.Add(this.lbl_activar);
            this.pnl_triki.Controls.Add(this.pnl_centc);
            this.pnl_triki.Controls.Add(this.pnl_topl);
            this.pnl_triki.Controls.Add(this.pnl_bottr);
            this.pnl_triki.Controls.Add(this.pnl_topc);
            this.pnl_triki.Controls.Add(this.pnl_bottc);
            this.pnl_triki.Controls.Add(this.pnl_topr);
            this.pnl_triki.Controls.Add(this.pnl_bottl);
            this.pnl_triki.Controls.Add(this.pnl_centl);
            this.pnl_triki.Controls.Add(this.pnl_centr);
            this.pnl_triki.Enabled = false;
            this.pnl_triki.Location = new System.Drawing.Point(264, 41);
            this.pnl_triki.Name = "pnl_triki";
            this.pnl_triki.Size = new System.Drawing.Size(215, 170);
            this.pnl_triki.TabIndex = 16;
            // 
            // lbl_activar
            // 
            this.lbl_activar.AutoSize = true;
            this.lbl_activar.Location = new System.Drawing.Point(57, 149);
            this.lbl_activar.Name = "lbl_activar";
            this.lbl_activar.Size = new System.Drawing.Size(97, 13);
            this.lbl_activar.TabIndex = 15;
            this.lbl_activar.Text = "Juego desactivado";
            // 
            // pnl_jugadores
            // 
            this.pnl_jugadores.Controls.Add(this.rbtn_jug2);
            this.pnl_jugadores.Controls.Add(this.rbtn_jug1);
            this.pnl_jugadores.Location = new System.Drawing.Point(265, 237);
            this.pnl_jugadores.Name = "pnl_jugadores";
            this.pnl_jugadores.Size = new System.Drawing.Size(214, 44);
            this.pnl_jugadores.TabIndex = 17;
            // 
            // btn_limcas
            // 
            this.btn_limcas.Location = new System.Drawing.Point(138, 200);
            this.btn_limcas.Name = "btn_limcas";
            this.btn_limcas.Size = new System.Drawing.Size(95, 23);
            this.btn_limcas.TabIndex = 19;
            this.btn_limcas.Text = "Volver a jugar";
            this.btn_limcas.UseVisualStyleBackColor = true;
            this.btn_limcas.Click += new System.EventHandler(this.btn_limcas_Click);
            // 
            // lbl_titulojug
            // 
            this.lbl_titulojug.AutoSize = true;
            this.lbl_titulojug.Location = new System.Drawing.Point(290, 221);
            this.lbl_titulojug.Name = "lbl_titulojug";
            this.lbl_titulojug.Size = new System.Drawing.Size(175, 13);
            this.lbl_titulojug.TabIndex = 20;
            this.lbl_titulojug.Text = "Seleccionar el jugador que empieza";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(149, 252);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_porcentaje
            // 
            this.btn_porcentaje.Enabled = false;
            this.btn_porcentaje.Location = new System.Drawing.Point(12, 249);
            this.btn_porcentaje.Name = "btn_porcentaje";
            this.btn_porcentaje.Size = new System.Drawing.Size(110, 23);
            this.btn_porcentaje.TabIndex = 22;
            this.btn_porcentaje.Text = "Calcular porcentaje";
            this.btn_porcentaje.UseVisualStyleBackColor = true;
            this.btn_porcentaje.Click += new System.EventHandler(this.btn_porcentaje_Click);
            // 
            // Triki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 304);
            this.Controls.Add(this.btn_porcentaje);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_titulojug);
            this.Controls.Add(this.btn_limcas);
            this.Controls.Add(this.pnl_jugadores);
            this.Controls.Add(this.pnl_triki);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pnl_contador);
            this.Name = "Triki";
            this.Text = "Triki";
            this.pnl_contador.ResumeLayout(false);
            this.pnl_contador.PerformLayout();
            this.pnl_triki.ResumeLayout(false);
            this.pnl_triki.PerformLayout();
            this.pnl_jugadores.ResumeLayout(false);
            this.pnl_jugadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vict;
        private System.Windows.Forms.Label lbl_jug1;
        private System.Windows.Forms.Label lbl_jug2;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.RadioButton rbtn_jug1;
        private System.Windows.Forms.RadioButton rbtn_jug2;
        private System.Windows.Forms.Panel pnl_contador;
        private System.Windows.Forms.Panel pnl_topl;
        private System.Windows.Forms.Panel pnl_topc;
        private System.Windows.Forms.Panel pnl_topr;
        private System.Windows.Forms.Panel pnl_centl;
        private System.Windows.Forms.Panel pnl_centc;
        private System.Windows.Forms.Panel pnl_centr;
        private System.Windows.Forms.Panel pnl_bottl;
        private System.Windows.Forms.Panel pnl_bottc;
        private System.Windows.Forms.Panel pnl_bottr;
        private System.Windows.Forms.Label lbl_numempa;
        private System.Windows.Forms.Label lbl_empa;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel pnl_triki;
        private System.Windows.Forms.Panel pnl_jugadores;
        private System.Windows.Forms.Label lbl_activar;
        private System.Windows.Forms.Button btn_limcas;
        private System.Windows.Forms.Label lbl_titulojug;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Label lbl_porcentaje2;
        private System.Windows.Forms.Label lbl_porcentaje1;
        private System.Windows.Forms.Button btn_porcentaje;
    }
}

