namespace proyectofinal_PTR
{
    partial class Seccion4
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaUsuarios = new System.Windows.Forms.ComboBox();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.Items.AddRange(new object[] {
            "Todos"});
            this.listaUsuarios.Location = new System.Drawing.Point(64, 6);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(121, 21);
            this.listaUsuarios.TabIndex = 1;
            this.listaUsuarios.SelectedIndexChanged += new System.EventHandler(this.listaUsuarios_SelectedIndexChanged);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.k1,
            this.m1,
            this.pos1,
            this.vel1,
            this.b,
            this.k2,
            this.m2,
            this.pos2,
            this.vel2});
            this.Tabla.Location = new System.Drawing.Point(12, 33);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(802, 312);
            this.Tabla.TabIndex = 2;
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // k1
            // 
            this.k1.HeaderText = "k1";
            this.k1.Name = "k1";
            // 
            // m1
            // 
            this.m1.HeaderText = "m1";
            this.m1.Name = "m1";
            // 
            // pos1
            // 
            this.pos1.HeaderText = "x1(0)";
            this.pos1.Name = "pos1";
            // 
            // vel1
            // 
            this.vel1.HeaderText = "ẋ1(0)";
            this.vel1.Name = "vel1";
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            // 
            // k2
            // 
            this.k2.HeaderText = "k2";
            this.k2.Name = "k2";
            // 
            // m2
            // 
            this.m2.HeaderText = "m2";
            this.m2.Name = "m2";
            // 
            // pos2
            // 
            this.pos2.HeaderText = "x2(0)";
            this.pos2.Name = "pos2";
            // 
            // vel2
            // 
            this.vel2.HeaderText = "ẋ2(0)";
            this.vel2.Name = "vel2";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(191, 4);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(103, 23);
            this.btn_Exportar.TabIndex = 3;
            this.btn_Exportar.Text = "Exportar a Excel";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // Seccion4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 353);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "Seccion4";
            this.Text = "Seccion4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seccion4_FormClosing);
            this.Load += new System.EventHandler(this.Seccion4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaUsuarios;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vel2;
        private System.Windows.Forms.Button btn_Exportar;
    }
}