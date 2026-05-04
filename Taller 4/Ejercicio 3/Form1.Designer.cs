namespace Taller4P3
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
            this.RbtnLetras = new System.Windows.Forms.RadioButton();
            this.RbtnNumeros = new System.Windows.Forms.RadioButton();
            this.Texto = new System.Windows.Forms.TextBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.ChkItalics = new System.Windows.Forms.CheckBox();
            this.ChkUnderlined = new System.Windows.Forms.CheckBox();
            this.ChkStrikeout = new System.Windows.Forms.CheckBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RbtnLetras
            // 
            this.RbtnLetras.AutoSize = true;
            this.RbtnLetras.Location = new System.Drawing.Point(22, 12);
            this.RbtnLetras.Name = "RbtnLetras";
            this.RbtnLetras.Size = new System.Drawing.Size(78, 17);
            this.RbtnLetras.TabIndex = 0;
            this.RbtnLetras.TabStop = true;
            this.RbtnLetras.Text = "Solo Letras";
            this.RbtnLetras.UseVisualStyleBackColor = true;
            this.RbtnLetras.CheckedChanged += new System.EventHandler(this.RbtnLetras_CheckedChanged);
            // 
            // RbtnNumeros
            // 
            this.RbtnNumeros.AutoSize = true;
            this.RbtnNumeros.Location = new System.Drawing.Point(22, 35);
            this.RbtnNumeros.Name = "RbtnNumeros";
            this.RbtnNumeros.Size = new System.Drawing.Size(91, 17);
            this.RbtnNumeros.TabIndex = 1;
            this.RbtnNumeros.TabStop = true;
            this.RbtnNumeros.Text = "Solo Números";
            this.RbtnNumeros.UseVisualStyleBackColor = true;
            this.RbtnNumeros.CheckedChanged += new System.EventHandler(this.RbtnNumeros_CheckedChanged);
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(22, 73);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(186, 20);
            this.Texto.TabIndex = 2;
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChanged);
            this.Texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Texto_KeyPress);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Location = new System.Drawing.Point(22, 118);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(61, 17);
            this.ChkBold.TabIndex = 3;
            this.ChkBold.Text = "Negrilla";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // ChkItalics
            // 
            this.ChkItalics.AutoSize = true;
            this.ChkItalics.Location = new System.Drawing.Point(22, 141);
            this.ChkItalics.Name = "ChkItalics";
            this.ChkItalics.Size = new System.Drawing.Size(61, 17);
            this.ChkItalics.TabIndex = 4;
            this.ChkItalics.Text = "Cursiva";
            this.ChkItalics.UseVisualStyleBackColor = true;
            this.ChkItalics.CheckedChanged += new System.EventHandler(this.ChkItalics_CheckedChanged);
            // 
            // ChkUnderlined
            // 
            this.ChkUnderlined.AutoSize = true;
            this.ChkUnderlined.Location = new System.Drawing.Point(22, 164);
            this.ChkUnderlined.Name = "ChkUnderlined";
            this.ChkUnderlined.Size = new System.Drawing.Size(77, 17);
            this.ChkUnderlined.TabIndex = 5;
            this.ChkUnderlined.Text = "Subrayado";
            this.ChkUnderlined.UseVisualStyleBackColor = true;
            this.ChkUnderlined.CheckedChanged += new System.EventHandler(this.ChkUnderlined_CheckedChanged);
            // 
            // ChkStrikeout
            // 
            this.ChkStrikeout.AutoSize = true;
            this.ChkStrikeout.Location = new System.Drawing.Point(22, 187);
            this.ChkStrikeout.Name = "ChkStrikeout";
            this.ChkStrikeout.Size = new System.Drawing.Size(69, 17);
            this.ChkStrikeout.TabIndex = 6;
            this.ChkStrikeout.Text = "Tachado";
            this.ChkStrikeout.UseVisualStyleBackColor = true;
            this.ChkStrikeout.CheckedChanged += new System.EventHandler(this.ChkStrikeout_CheckedChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(133, 181);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 218);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.ChkStrikeout);
            this.Controls.Add(this.ChkUnderlined);
            this.Controls.Add(this.ChkItalics);
            this.Controls.Add(this.ChkBold);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.RbtnNumeros);
            this.Controls.Add(this.RbtnLetras);
            this.Name = "Form1";
            this.Text = "Taller 4, Punto 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnLetras;
        private System.Windows.Forms.RadioButton RbtnNumeros;
        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.CheckBox ChkItalics;
        private System.Windows.Forms.CheckBox ChkUnderlined;
        private System.Windows.Forms.CheckBox ChkStrikeout;
        private System.Windows.Forms.Button BtnSalir;
    }
}

