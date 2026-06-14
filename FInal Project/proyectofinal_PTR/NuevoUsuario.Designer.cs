namespace proyectofinal_PTR
{
    partial class NuevoUsuario
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_identidad = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_tipo = new System.Windows.Forms.Label();
            this.rbt_admin = new System.Windows.Forms.RadioButton();
            this.rbt_estandard = new System.Windows.Forms.RadioButton();
            this.pnl_rbt_tipo = new System.Windows.Forms.Panel();
            this.pnl_rbt_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(104, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(252, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Ingresar todos los datos para la creacion del usuario";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(46, 85);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(93, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre completo:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(40, 116);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(99, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Nombre de usuario:";
            // 
            // lbl_identidad
            // 
            this.lbl_identidad.AutoSize = true;
            this.lbl_identidad.Location = new System.Drawing.Point(25, 147);
            this.lbl_identidad.Name = "lbl_identidad";
            this.lbl_identidad.Size = new System.Drawing.Size(129, 13);
            this.lbl_identidad.TabIndex = 3;
            this.lbl_identidad.Text = "Documento de identidad: ";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(40, 177);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(92, 13);
            this.lbl_correo.TabIndex = 4;
            this.lbl_correo.Text = "Ingrese su correo:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(25, 204);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(115, 13);
            this.lbl_contraseña.TabIndex = 5;
            this.lbl_contraseña.Text = "Ingrese su contraseña:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(106, 260);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(112, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Crear nuevo usuario";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(160, 82);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(160, 113);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 8;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(160, 144);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(100, 20);
            this.txt_documento.TabIndex = 9;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(160, 174);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 10;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(160, 204);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(224, 260);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_tipo
            // 
            this.txt_tipo.AutoSize = true;
            this.txt_tipo.Location = new System.Drawing.Point(46, 56);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(83, 13);
            this.txt_tipo.TabIndex = 13;
            this.txt_tipo.Text = "Tipo de usuario:";
            // 
            // rbt_admin
            // 
            this.rbt_admin.AutoSize = true;
            this.rbt_admin.Location = new System.Drawing.Point(25, 8);
            this.rbt_admin.Name = "rbt_admin";
            this.rbt_admin.Size = new System.Drawing.Size(88, 17);
            this.rbt_admin.TabIndex = 14;
            this.rbt_admin.Text = "Administrador";
            this.rbt_admin.UseVisualStyleBackColor = true;
            // 
            // rbt_estandard
            // 
            this.rbt_estandard.AutoSize = true;
            this.rbt_estandard.Checked = true;
            this.rbt_estandard.Location = new System.Drawing.Point(135, 8);
            this.rbt_estandard.Name = "rbt_estandard";
            this.rbt_estandard.Size = new System.Drawing.Size(112, 17);
            this.rbt_estandard.TabIndex = 15;
            this.rbt_estandard.TabStop = true;
            this.rbt_estandard.Text = "Usuario Estandard";
            this.rbt_estandard.UseVisualStyleBackColor = true;
            // 
            // pnl_rbt_tipo
            // 
            this.pnl_rbt_tipo.Controls.Add(this.rbt_estandard);
            this.pnl_rbt_tipo.Controls.Add(this.rbt_admin);
            this.pnl_rbt_tipo.Location = new System.Drawing.Point(135, 48);
            this.pnl_rbt_tipo.Name = "pnl_rbt_tipo";
            this.pnl_rbt_tipo.Size = new System.Drawing.Size(300, 28);
            this.pnl_rbt_tipo.TabIndex = 16;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 306);
            this.Controls.Add(this.pnl_rbt_tipo);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_identidad);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoUsuario_FormClosing);
            this.pnl_rbt_tipo.ResumeLayout(false);
            this.pnl_rbt_tipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_identidad;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label txt_tipo;
        private System.Windows.Forms.RadioButton rbt_admin;
        private System.Windows.Forms.RadioButton rbt_estandard;
        private System.Windows.Forms.Panel pnl_rbt_tipo;
    }
}