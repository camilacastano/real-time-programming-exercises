namespace EjemploMetodos20222
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.chkMultiplicacion = new System.Windows.Forms.CheckBox();
            this.chkDivision = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularClase = new System.Windows.Forms.Button();
            this.btnEnumeracion = new System.Windows.Forms.Button();
            this.lblEnumeracion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 287);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 46);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(211, 69);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 31);
            this.txtDato1.TabIndex = 1;
            this.txtDato1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato1_KeyPress);
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(211, 116);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 31);
            this.txtDato2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dato 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(265, 363);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "El resultado es:";
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(366, 34);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(55, 29);
            this.rbtnSuma.TabIndex = 7;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "+";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            this.rbtnSuma.CheckedChanged += new System.EventHandler(this.rbtnSuma_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(366, 69);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(50, 29);
            this.rbtnResta.TabIndex = 8;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "-";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.CheckedChanged += new System.EventHandler(this.rbtnResta_CheckedChanged);
            // 
            // chkMultiplicacion
            // 
            this.chkMultiplicacion.AutoSize = true;
            this.chkMultiplicacion.Location = new System.Drawing.Point(366, 115);
            this.chkMultiplicacion.Name = "chkMultiplicacion";
            this.chkMultiplicacion.Size = new System.Drawing.Size(52, 29);
            this.chkMultiplicacion.TabIndex = 11;
            this.chkMultiplicacion.Text = "*";
            this.chkMultiplicacion.UseVisualStyleBackColor = true;
            this.chkMultiplicacion.CheckedChanged += new System.EventHandler(this.chkMultiplicacion_CheckedChanged);
            // 
            // chkDivision
            // 
            this.chkDivision.AutoSize = true;
            this.chkDivision.Location = new System.Drawing.Point(366, 150);
            this.chkDivision.Name = "chkDivision";
            this.chkDivision.Size = new System.Drawing.Size(50, 29);
            this.chkDivision.TabIndex = 12;
            this.chkDivision.Text = "/";
            this.chkDivision.UseVisualStyleBackColor = true;
            this.chkDivision.CheckedChanged += new System.EventHandler(this.chkDivision_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcularClase);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.chkDivision);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.chkMultiplicacion);
            this.panel1.Controls.Add(this.txtDato1);
            this.panel1.Controls.Add(this.rbtnResta);
            this.panel1.Controls.Add(this.txtDato2);
            this.panel1.Controls.Add(this.rbtnSuma);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(92, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 440);
            this.panel1.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 29);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 136);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 171);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(165, 29);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(165, 29);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(35, 45);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(165, 29);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(35, 115);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(165, 29);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pregunta 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pregunta 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(1053, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 209);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Location = new System.Drawing.Point(1053, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 168);
            this.panel3.TabIndex = 23;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 25;
            this.lstHistorial.Location = new System.Drawing.Point(581, 98);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(212, 254);
            this.lstHistorial.TabIndex = 24;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Historial (ultimas 5 operaciones)";
            // 
            // btnCalcularClase
            // 
            this.btnCalcularClase.Location = new System.Drawing.Point(128, 214);
            this.btnCalcularClase.Name = "btnCalcularClase";
            this.btnCalcularClase.Size = new System.Drawing.Size(207, 46);
            this.btnCalcularClase.TabIndex = 13;
            this.btnCalcularClase.Text = "Calcular con clase";
            this.btnCalcularClase.UseVisualStyleBackColor = true;
            this.btnCalcularClase.Click += new System.EventHandler(this.btnCalcularClase_Click);
            // 
            // btnEnumeracion
            // 
            this.btnEnumeracion.Location = new System.Drawing.Point(622, 431);
            this.btnEnumeracion.Name = "btnEnumeracion";
            this.btnEnumeracion.Size = new System.Drawing.Size(171, 62);
            this.btnEnumeracion.TabIndex = 26;
            this.btnEnumeracion.Text = "Enumeracion";
            this.btnEnumeracion.UseVisualStyleBackColor = true;
            this.btnEnumeracion.Click += new System.EventHandler(this.btnEnumeracion_Click);
            // 
            // lblEnumeracion
            // 
            this.lblEnumeracion.AutoSize = true;
            this.lblEnumeracion.Location = new System.Drawing.Point(676, 532);
            this.lblEnumeracion.Name = "lblEnumeracion";
            this.lblEnumeracion.Size = new System.Drawing.Size(70, 25);
            this.lblEnumeracion.TabIndex = 27;
            this.lblEnumeracion.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 610);
            this.Controls.Add(this.lblEnumeracion);
            this.Controls.Add(this.btnEnumeracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.CheckBox chkMultiplicacion;
        private System.Windows.Forms.CheckBox chkDivision;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularClase;
        private System.Windows.Forms.Button btnEnumeracion;
        private System.Windows.Forms.Label lblEnumeracion;
    }
}

