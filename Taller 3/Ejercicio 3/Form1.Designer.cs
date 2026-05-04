namespace Taller3P3
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
            this.EtqLargo = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.IngresoLargo = new System.Windows.Forms.TextBox();
            this.EtqAncho = new System.Windows.Forms.Label();
            this.IngresoAncho = new System.Windows.Forms.TextBox();
            this.IngresoArea = new System.Windows.Forms.TextBox();
            this.EtqArea = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.UnaIt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EtqLargo
            // 
            this.EtqLargo.AutoSize = true;
            this.EtqLargo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqLargo.Location = new System.Drawing.Point(12, 28);
            this.EtqLargo.Name = "EtqLargo";
            this.EtqLargo.Size = new System.Drawing.Size(114, 19);
            this.EtqLargo.TabIndex = 0;
            this.EtqLargo.Text = "Ingrese el largo:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(252, 47);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 29);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // IngresoLargo
            // 
            this.IngresoLargo.Location = new System.Drawing.Point(132, 29);
            this.IngresoLargo.Name = "IngresoLargo";
            this.IngresoLargo.Size = new System.Drawing.Size(100, 20);
            this.IngresoLargo.TabIndex = 2;
            this.IngresoLargo.TextChanged += new System.EventHandler(this.IngresoLargo_TextChanged);
            // 
            // EtqAncho
            // 
            this.EtqAncho.AutoSize = true;
            this.EtqAncho.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqAncho.Location = new System.Drawing.Point(12, 67);
            this.EtqAncho.Name = "EtqAncho";
            this.EtqAncho.Size = new System.Drawing.Size(120, 19);
            this.EtqAncho.TabIndex = 3;
            this.EtqAncho.Text = "Ingrese el ancho:";
            // 
            // IngresoAncho
            // 
            this.IngresoAncho.Location = new System.Drawing.Point(132, 65);
            this.IngresoAncho.Name = "IngresoAncho";
            this.IngresoAncho.Size = new System.Drawing.Size(100, 20);
            this.IngresoAncho.TabIndex = 4;
            this.IngresoAncho.TextChanged += new System.EventHandler(this.IngresoAncho_TextChanged);
            // 
            // IngresoArea
            // 
            this.IngresoArea.Location = new System.Drawing.Point(132, 101);
            this.IngresoArea.Name = "IngresoArea";
            this.IngresoArea.Size = new System.Drawing.Size(100, 20);
            this.IngresoArea.TabIndex = 7;
            this.IngresoArea.TextChanged += new System.EventHandler(this.IngresoArea_TextChanged);
            // 
            // EtqArea
            // 
            this.EtqArea.AutoSize = true;
            this.EtqArea.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqArea.Location = new System.Drawing.Point(18, 100);
            this.EtqArea.Name = "EtqArea";
            this.EtqArea.Size = new System.Drawing.Size(108, 19);
            this.EtqArea.TabIndex = 6;
            this.EtqArea.Text = "Ingrese el área:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(252, 82);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(84, 28);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Finalizar";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // UnaIt
            // 
            this.UnaIt.AutoSize = true;
            this.UnaIt.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnaIt.Location = new System.Drawing.Point(102, 141);
            this.UnaIt.Name = "UnaIt";
            this.UnaIt.Size = new System.Drawing.Size(156, 23);
            this.UnaIt.TabIndex = 9;
            this.UnaIt.Text = "Hacer una iteración";
            this.UnaIt.UseVisualStyleBackColor = true;
            this.UnaIt.CheckedChanged += new System.EventHandler(this.UnaIt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 192);
            this.Controls.Add(this.UnaIt);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.IngresoArea);
            this.Controls.Add(this.EtqArea);
            this.Controls.Add(this.IngresoAncho);
            this.Controls.Add(this.EtqAncho);
            this.Controls.Add(this.IngresoLargo);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.EtqLargo);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtqLargo;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox IngresoLargo;
        private System.Windows.Forms.Label EtqAncho;
        private System.Windows.Forms.TextBox IngresoAncho;
        private System.Windows.Forms.TextBox IngresoArea;
        private System.Windows.Forms.Label EtqArea;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.CheckBox UnaIt;
    }
}

