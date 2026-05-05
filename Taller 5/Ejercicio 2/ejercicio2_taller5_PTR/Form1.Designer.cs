namespace ejercicio2_taller5_PTR
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
            this.mnst_principal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTamañoLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_textoingresado = new System.Windows.Forms.TextBox();
            this.txt_sololectura = new System.Windows.Forms.TextBox();
            this.lbl_sololectura = new System.Windows.Forms.Label();
            this.hsb_sizeletra = new System.Windows.Forms.HScrollBar();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_tamletra = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_okdtp = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_escritura = new System.Windows.Forms.Label();
            this.mnst_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnst_principal
            // 
            this.mnst_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.insertarToolStripMenuItem});
            this.mnst_principal.Location = new System.Drawing.Point(0, 0);
            this.mnst_principal.Name = "mnst_principal";
            this.mnst_principal.Size = new System.Drawing.Size(599, 24);
            this.mnst_principal.TabIndex = 0;
            this.mnst_principal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarTamañoLetraToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // modificarTamañoLetraToolStripMenuItem
            // 
            this.modificarTamañoLetraToolStripMenuItem.Name = "modificarTamañoLetraToolStripMenuItem";
            this.modificarTamañoLetraToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modificarTamañoLetraToolStripMenuItem.Text = "Modificar Tamaño Letra";
            this.modificarTamañoLetraToolStripMenuItem.Click += new System.EventHandler(this.modificarTamañoLetraToolStripMenuItem_Click);
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            this.fechaToolStripMenuItem.Click += new System.EventHandler(this.fechaToolStripMenuItem_Click);
            // 
            // txt_textoingresado
            // 
            this.txt_textoingresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_textoingresado.Location = new System.Drawing.Point(57, 65);
            this.txt_textoingresado.Multiline = true;
            this.txt_textoingresado.Name = "txt_textoingresado";
            this.txt_textoingresado.Size = new System.Drawing.Size(192, 95);
            this.txt_textoingresado.TabIndex = 1;
            // 
            // txt_sololectura
            // 
            this.txt_sololectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sololectura.Location = new System.Drawing.Point(333, 65);
            this.txt_sololectura.Multiline = true;
            this.txt_sololectura.Name = "txt_sololectura";
            this.txt_sololectura.ReadOnly = true;
            this.txt_sololectura.Size = new System.Drawing.Size(188, 95);
            this.txt_sololectura.TabIndex = 2;
            // 
            // lbl_sololectura
            // 
            this.lbl_sololectura.AutoSize = true;
            this.lbl_sololectura.Location = new System.Drawing.Point(392, 163);
            this.lbl_sololectura.Name = "lbl_sololectura";
            this.lbl_sololectura.Size = new System.Drawing.Size(75, 13);
            this.lbl_sololectura.TabIndex = 3;
            this.lbl_sololectura.Text = "*Solo Lectura*";
            // 
            // hsb_sizeletra
            // 
            this.hsb_sizeletra.LargeChange = 1;
            this.hsb_sizeletra.Location = new System.Drawing.Point(57, 195);
            this.hsb_sizeletra.Maximum = 30;
            this.hsb_sizeletra.Minimum = 2;
            this.hsb_sizeletra.Name = "hsb_sizeletra";
            this.hsb_sizeletra.Size = new System.Drawing.Size(214, 25);
            this.hsb_sizeletra.TabIndex = 4;
            this.hsb_sizeletra.Value = 2;
            this.hsb_sizeletra.Visible = false;
            this.hsb_sizeletra.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_sizeletra_Scroll);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(70, 235);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_tamletra
            // 
            this.lbl_tamletra.AutoSize = true;
            this.lbl_tamletra.Location = new System.Drawing.Point(201, 240);
            this.lbl_tamletra.Name = "lbl_tamletra";
            this.lbl_tamletra.Size = new System.Drawing.Size(19, 13);
            this.lbl_tamletra.TabIndex = 6;
            this.lbl_tamletra.Text = "10";
            this.lbl_tamletra.Visible = false;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(333, 195);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 7;
            this.dtp_fecha.Visible = false;
            // 
            // btn_okdtp
            // 
            this.btn_okdtp.Location = new System.Drawing.Point(392, 235);
            this.btn_okdtp.Name = "btn_okdtp";
            this.btn_okdtp.Size = new System.Drawing.Size(75, 23);
            this.btn_okdtp.TabIndex = 8;
            this.btn_okdtp.Text = "OK";
            this.btn_okdtp.UseVisualStyleBackColor = true;
            this.btn_okdtp.Visible = false;
            this.btn_okdtp.Click += new System.EventHandler(this.btn_okdtp_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(259, 269);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(84, 25);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(267, 38);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(56, 13);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Ejercicio 2";
            // 
            // lbl_escritura
            // 
            this.lbl_escritura.AutoSize = true;
            this.lbl_escritura.Location = new System.Drawing.Point(88, 163);
            this.lbl_escritura.Name = "lbl_escritura";
            this.lbl_escritura.Size = new System.Drawing.Size(132, 13);
            this.lbl_escritura.TabIndex = 11;
            this.lbl_escritura.Text = "*Escribir en este recuadro*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 306);
            this.Controls.Add(this.lbl_escritura);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_okdtp);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.lbl_tamletra);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.hsb_sizeletra);
            this.Controls.Add(this.lbl_sololectura);
            this.Controls.Add(this.txt_sololectura);
            this.Controls.Add(this.txt_textoingresado);
            this.Controls.Add(this.mnst_principal);
            this.MainMenuStrip = this.mnst_principal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnst_principal.ResumeLayout(false);
            this.mnst_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnst_principal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_textoingresado;
        private System.Windows.Forms.TextBox txt_sololectura;
        private System.Windows.Forms.Label lbl_sololectura;
        private System.Windows.Forms.HScrollBar hsb_sizeletra;
        private System.Windows.Forms.ToolStripMenuItem modificarTamañoLetraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_tamletra;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_okdtp;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_escritura;
    }
}

