namespace terceroTaller3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlargo = new System.Windows.Forms.TextBox();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.txtalto = new System.Windows.Forms.TextBox();
            this.volumen = new System.Windows.Forms.Button();
            this.lbllargo = new System.Windows.Forms.Label();
            this.lblancho = new System.Windows.Forms.Label();
            this.lblalto = new System.Windows.Forms.Label();
            this.lblvolumen = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRISMA RECTANGULAR";
            // 
            // txtlargo
            // 
            this.txtlargo.Location = new System.Drawing.Point(362, 107);
            this.txtlargo.Name = "txtlargo";
            this.txtlargo.Size = new System.Drawing.Size(100, 22);
            this.txtlargo.TabIndex = 1;
            // 
            // txtancho
            // 
            this.txtancho.Location = new System.Drawing.Point(362, 162);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(100, 22);
            this.txtancho.TabIndex = 2;
            // 
            // txtalto
            // 
            this.txtalto.Location = new System.Drawing.Point(362, 215);
            this.txtalto.Name = "txtalto";
            this.txtalto.Size = new System.Drawing.Size(100, 22);
            this.txtalto.TabIndex = 3;
            // 
            // volumen
            // 
            this.volumen.Location = new System.Drawing.Point(152, 332);
            this.volumen.Name = "volumen";
            this.volumen.Size = new System.Drawing.Size(161, 23);
            this.volumen.TabIndex = 4;
            this.volumen.Text = "Calcular volumen";
            this.volumen.UseVisualStyleBackColor = true;
            this.volumen.Click += new System.EventHandler(this.volumen_Click);
            // 
            // lbllargo
            // 
            this.lbllargo.AutoSize = true;
            this.lbllargo.Location = new System.Drawing.Point(149, 110);
            this.lbllargo.Name = "lbllargo";
            this.lbllargo.Size = new System.Drawing.Size(110, 17);
            this.lbllargo.TabIndex = 5;
            this.lbllargo.Text = "Ingrese el largo:";
            // 
            // lblancho
            // 
            this.lblancho.AutoSize = true;
            this.lblancho.Location = new System.Drawing.Point(149, 162);
            this.lblancho.Name = "lblancho";
            this.lblancho.Size = new System.Drawing.Size(121, 17);
            this.lblancho.TabIndex = 6;
            this.lblancho.Text = "Ingrese el ancho: ";
            // 
            // lblalto
            // 
            this.lblalto.AutoSize = true;
            this.lblalto.Location = new System.Drawing.Point(149, 215);
            this.lblalto.Name = "lblalto";
            this.lblalto.Size = new System.Drawing.Size(101, 17);
            this.lblalto.TabIndex = 7;
            this.lblalto.Text = "Ingrese el alto:";
            // 
            // lblvolumen
            // 
            this.lblvolumen.AutoSize = true;
            this.lblvolumen.Location = new System.Drawing.Point(259, 279);
            this.lblvolumen.Name = "lblvolumen";
            this.lblvolumen.Size = new System.Drawing.Size(0, 17);
            this.lblvolumen.TabIndex = 8;
            this.lblvolumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(386, 332);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(75, 23);
            this.inicio.TabIndex = 9;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 412);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.lblvolumen);
            this.Controls.Add(this.lblalto);
            this.Controls.Add(this.lblancho);
            this.Controls.Add(this.lbllargo);
            this.Controls.Add(this.volumen);
            this.Controls.Add(this.txtalto);
            this.Controls.Add(this.txtancho);
            this.Controls.Add(this.txtlargo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlargo;
        private System.Windows.Forms.TextBox txtancho;
        private System.Windows.Forms.TextBox txtalto;
        private System.Windows.Forms.Button volumen;
        private System.Windows.Forms.Label lbllargo;
        private System.Windows.Forms.Label lblancho;
        private System.Windows.Forms.Label lblalto;
        private System.Windows.Forms.Label lblvolumen;
        private System.Windows.Forms.Button inicio;
    }
}

