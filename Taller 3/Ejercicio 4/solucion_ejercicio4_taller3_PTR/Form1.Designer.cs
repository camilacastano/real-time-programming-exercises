namespace solucion_ejercicio4_taller3_PTR
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
            this.lblan = new System.Windows.Forms.Label();
            this.lblal = new System.Windows.Forms.Label();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.txt_ancho = new System.Windows.Forms.TextBox();
            this.txt_alto = new System.Windows.Forms.TextBox();
            this.txt_largo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bton_vol_dig = new System.Windows.Forms.Button();
            this.lblvol = new System.Windows.Forms.Label();
            this.volu = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.diag = new System.Windows.Forms.Label();
            this.bton_reset = new System.Windows.Forms.Button();
            this.bton_salir = new System.Windows.Forms.Button();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblan
            // 
            this.lblan.AutoSize = true;
            this.lblan.Location = new System.Drawing.Point(20, 58);
            this.lblan.Name = "lblan";
            this.lblan.Size = new System.Drawing.Size(44, 13);
            this.lblan.TabIndex = 0;
            this.lblan.Text = "Ancho: ";
            // 
            // lblal
            // 
            this.lblal.AutoSize = true;
            this.lblal.Location = new System.Drawing.Point(20, 96);
            this.lblal.Name = "lblal";
            this.lblal.Size = new System.Drawing.Size(28, 13);
            this.lblal.TabIndex = 1;
            this.lblal.Text = "Alto:";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Location = new System.Drawing.Point(20, 130);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(40, 13);
            this.lbl_alto.TabIndex = 2;
            this.lbl_alto.Text = "Largo: ";
            // 
            // txt_ancho
            // 
            this.txt_ancho.Location = new System.Drawing.Point(70, 55);
            this.txt_ancho.Name = "txt_ancho";
            this.txt_ancho.Size = new System.Drawing.Size(100, 20);
            this.txt_ancho.TabIndex = 3;
            // 
            // txt_alto
            // 
            this.txt_alto.Location = new System.Drawing.Point(70, 93);
            this.txt_alto.Name = "txt_alto";
            this.txt_alto.Size = new System.Drawing.Size(100, 20);
            this.txt_alto.TabIndex = 4;
            // 
            // txt_largo
            // 
            this.txt_largo.Location = new System.Drawing.Point(70, 130);
            this.txt_largo.Name = "txt_largo";
            this.txt_largo.Size = new System.Drawing.Size(100, 20);
            this.txt_largo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calculo del volumen de un prisma rectangular";
            // 
            // bton_vol_dig
            // 
            this.bton_vol_dig.Location = new System.Drawing.Point(134, 193);
            this.bton_vol_dig.Name = "bton_vol_dig";
            this.bton_vol_dig.Size = new System.Drawing.Size(114, 23);
            this.bton_vol_dig.TabIndex = 7;
            this.bton_vol_dig.Text = "Calcular volumen";
            this.bton_vol_dig.UseVisualStyleBackColor = true;
            this.bton_vol_dig.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblvol
            // 
            this.lblvol.AutoSize = true;
            this.lblvol.Location = new System.Drawing.Point(214, 79);
            this.lblvol.Name = "lblvol";
            this.lblvol.Size = new System.Drawing.Size(51, 13);
            this.lblvol.TabIndex = 8;
            this.lblvol.Text = "Volumen:";
            // 
            // volu
            // 
            this.volu.AutoSize = true;
            this.volu.Location = new System.Drawing.Point(276, 79);
            this.volu.Name = "volu";
            this.volu.Size = new System.Drawing.Size(0, 13);
            this.volu.TabIndex = 9;
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(214, 119);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(55, 13);
            this.lbldia.TabIndex = 10;
            this.lbldia.Text = "Diagonal: ";
            // 
            // diag
            // 
            this.diag.AutoSize = true;
            this.diag.Location = new System.Drawing.Point(273, 119);
            this.diag.Name = "diag";
            this.diag.Size = new System.Drawing.Size(0, 13);
            this.diag.TabIndex = 11;
            // 
            // bton_reset
            // 
            this.bton_reset.Location = new System.Drawing.Point(60, 258);
            this.bton_reset.Name = "bton_reset";
            this.bton_reset.Size = new System.Drawing.Size(75, 23);
            this.bton_reset.TabIndex = 12;
            this.bton_reset.Text = "Reset";
            this.bton_reset.UseVisualStyleBackColor = true;
            this.bton_reset.Visible = false;
            this.bton_reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // bton_salir
            // 
            this.bton_salir.Location = new System.Drawing.Point(242, 258);
            this.bton_salir.Name = "bton_salir";
            this.bton_salir.Size = new System.Drawing.Size(75, 23);
            this.bton_salir.TabIndex = 13;
            this.bton_salir.Text = "Salir";
            this.bton_salir.UseVisualStyleBackColor = true;
            this.bton_salir.Visible = false;
            this.bton_salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.Location = new System.Drawing.Point(135, 167);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(0, 13);
            this.lbl_aviso.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 314);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.bton_salir);
            this.Controls.Add(this.bton_reset);
            this.Controls.Add(this.diag);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.volu);
            this.Controls.Add(this.lblvol);
            this.Controls.Add(this.bton_vol_dig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_largo);
            this.Controls.Add(this.txt_alto);
            this.Controls.Add(this.txt_ancho);
            this.Controls.Add(this.lbl_alto);
            this.Controls.Add(this.lblal);
            this.Controls.Add(this.lblan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblan;
        private System.Windows.Forms.Label lblal;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.TextBox txt_ancho;
        private System.Windows.Forms.TextBox txt_alto;
        private System.Windows.Forms.TextBox txt_largo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bton_vol_dig;
        private System.Windows.Forms.Label lblvol;
        private System.Windows.Forms.Label volu;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label diag;
        private System.Windows.Forms.Button bton_reset;
        private System.Windows.Forms.Button bton_salir;
        private System.Windows.Forms.Label lbl_aviso;
    }
}

