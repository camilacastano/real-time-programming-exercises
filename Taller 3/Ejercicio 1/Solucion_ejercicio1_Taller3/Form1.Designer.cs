namespace Solucion_ejercicio1_Taller3
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
            this.btn_acciones = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_acciones
            // 
            this.btn_acciones.Location = new System.Drawing.Point(99, 98);
            this.btn_acciones.Name = "btn_acciones";
            this.btn_acciones.Size = new System.Drawing.Size(101, 23);
            this.btn_acciones.TabIndex = 0;
            this.btn_acciones.Text = "Alterar mensaje";
            this.btn_acciones.UseVisualStyleBackColor = true;
            this.btn_acciones.Click += new System.EventHandler(this.btn_acciones_Click);
            this.btn_acciones.MouseEnter += new System.EventHandler(this.btn_acciones_MouseEnter);
            this.btn_acciones.MouseLeave += new System.EventHandler(this.btn_acciones_MouseLeave);
            this.btn_acciones.MouseHover += new System.EventHandler(this.btn_acciones_MouseHover);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(106, 43);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(81, 13);
            this.lbl_mensaje.TabIndex = 1;
            this.lbl_mensaje.Text = "Activar eventos";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(109, 145);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(66, 22);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 211);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_acciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_acciones;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button btn_salir;
    }
}

