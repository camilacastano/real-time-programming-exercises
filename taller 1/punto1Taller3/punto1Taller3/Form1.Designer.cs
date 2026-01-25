namespace punto1Taller3
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
            this.lblb = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblb.Location = new System.Drawing.Point(275, 96);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(78, 17);
            this.lblb.TabIndex = 0;
            this.lblb.Text = "Bienvenido";
            this.lblb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(233, 152);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(161, 23);
            this.click.TabIndex = 1;
            this.click.Text = "Presione click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(204, 217);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(75, 23);
            this.inicio.TabIndex = 2;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.VisibleChanged += new System.EventHandler(this.inicio_VisibleChanged);
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(342, 217);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 3;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.VisibleChanged += new System.EventHandler(this.cerrar_VisibleChanged);
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 288);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.click);
            this.Controls.Add(this.lblb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button cerrar;
    }
}

