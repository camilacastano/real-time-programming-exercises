namespace solucion_ejercicio2_taller3_PTR
{
    partial class Ventana
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_eventoclick = new System.Windows.Forms.Button();
            this.bton_reset = new System.Windows.Forms.Button();
            this.bton_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(24, 21);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(63, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Bienvenido:";
            // 
            // btn_eventoclick
            // 
            this.btn_eventoclick.Location = new System.Drawing.Point(159, 16);
            this.btn_eventoclick.Name = "btn_eventoclick";
            this.btn_eventoclick.Size = new System.Drawing.Size(95, 23);
            this.btn_eventoclick.TabIndex = 1;
            this.btn_eventoclick.Text = "Presione Click";
            this.btn_eventoclick.UseVisualStyleBackColor = true;
            this.btn_eventoclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // bton_reset
            // 
            this.bton_reset.Location = new System.Drawing.Point(27, 144);
            this.bton_reset.Name = "bton_reset";
            this.bton_reset.Size = new System.Drawing.Size(75, 23);
            this.bton_reset.TabIndex = 2;
            this.bton_reset.Text = "Reset";
            this.bton_reset.UseVisualStyleBackColor = true;
            this.bton_reset.Visible = false;
            this.bton_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // bton_salir
            // 
            this.bton_salir.AllowDrop = true;
            this.bton_salir.Location = new System.Drawing.Point(171, 144);
            this.bton_salir.Name = "bton_salir";
            this.bton_salir.Size = new System.Drawing.Size(74, 23);
            this.bton_salir.TabIndex = 3;
            this.bton_salir.Text = "Salir";
            this.bton_salir.UseVisualStyleBackColor = true;
            this.bton_salir.Visible = false;
            this.bton_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.bton_salir);
            this.Controls.Add(this.bton_reset);
            this.Controls.Add(this.btn_eventoclick);
            this.Controls.Add(this.lbl_1);
            this.Name = "Ventana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_eventoclick;
        private System.Windows.Forms.Button bton_reset;
        private System.Windows.Forms.Button bton_salir;
    }
}

