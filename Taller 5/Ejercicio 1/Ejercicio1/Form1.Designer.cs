namespace Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 240);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.textCorreo);
            this.tabPage1.Controls.Add(this.textEdad);
            this.tabPage1.Controls.Add(this.textNombre);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.lbl3);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(93, 124);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(205, 21);
            this.textCorreo.TabIndex = 13;
            this.textCorreo.TextChanged += new System.EventHandler(this.textCorreo_TextChanged);
            this.textCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCorreo_KeyPress);
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(93, 94);
            this.textEdad.MaxLength = 3;
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(66, 21);
            this.textEdad.TabIndex = 12;
            this.textEdad.TextChanged += new System.EventHandler(this.textEdad_TextChanged);
            this.textEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdad_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(93, 60);
            this.textNombre.MaxLength = 20;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(205, 21);
            this.textNombre.TabIndex = 11;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(155, 166);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 26);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Registrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl3.Location = new System.Drawing.Point(25, 130);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 15);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Correo";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl2.Location = new System.Drawing.Point(25, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(36, 15);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Edad";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(25, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 15);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRegresar);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edad Persona";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(159, 140);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cooper Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(115, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(183, 19);
            this.label.TabIndex = 14;
            this.label.Text = "Verificación de Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label;
    }
}

