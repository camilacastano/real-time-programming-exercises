namespace ejercicio_1
{
    partial class Form1
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
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.pnlCursor = new System.Windows.Forms.Panel();
            this.btn_anchoplus = new System.Windows.Forms.Button();
            this.btn_altoplus = new System.Windows.Forms.Button();
            this.pnlPrueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(102, 26);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(60, 28);
            this.btnArriba.TabIndex = 1;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(102, 127);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(60, 25);
            this.btnAbajo.TabIndex = 1;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(36, 79);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(64, 28);
            this.btnIzquierda.TabIndex = 4;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(166, 79);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(71, 28);
            this.btnDerecha.TabIndex = 3;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(188, 360);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(73, 39);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // pnlPrueba
            // 
            this.pnlPrueba.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlPrueba.Controls.Add(this.pnlCursor);
            this.pnlPrueba.Location = new System.Drawing.Point(295, 26);
            this.pnlPrueba.Name = "pnlPrueba";
            this.pnlPrueba.Size = new System.Drawing.Size(328, 305);
            this.pnlPrueba.TabIndex = 0;
            // 
            // pnlCursor
            // 
            this.pnlCursor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCursor.Location = new System.Drawing.Point(117, 124);
            this.pnlCursor.Name = "pnlCursor";
            this.pnlCursor.Size = new System.Drawing.Size(103, 64);
            this.pnlCursor.TabIndex = 0;
            // 
            // btn_anchoplus
            // 
            this.btn_anchoplus.Location = new System.Drawing.Point(12, 211);
            this.btn_anchoplus.Name = "btn_anchoplus";
            this.btn_anchoplus.Size = new System.Drawing.Size(107, 28);
            this.btn_anchoplus.TabIndex = 6;
            this.btn_anchoplus.Text = "Aumentar Ancho";
            this.btn_anchoplus.UseVisualStyleBackColor = true;
            this.btn_anchoplus.Click += new System.EventHandler(this.btn_anchoplus_Click);
            // 
            // btn_altoplus
            // 
            this.btn_altoplus.Location = new System.Drawing.Point(154, 211);
            this.btn_altoplus.Name = "btn_altoplus";
            this.btn_altoplus.Size = new System.Drawing.Size(107, 28);
            this.btn_altoplus.TabIndex = 7;
            this.btn_altoplus.Text = "Aumentar Alto";
            this.btn_altoplus.UseVisualStyleBackColor = true;
            this.btn_altoplus.Click += new System.EventHandler(this.btn_altoplus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 434);
            this.Controls.Add(this.btn_altoplus);
            this.Controls.Add(this.btn_anchoplus);
            this.Controls.Add(this.pnlPrueba);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.pnlPrueba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Panel pnlCursor;
        private System.Windows.Forms.Button btn_anchoplus;
        private System.Windows.Forms.Button btn_altoplus;
    }
}

