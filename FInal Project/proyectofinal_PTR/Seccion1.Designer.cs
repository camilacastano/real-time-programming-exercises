namespace proyectofinal_PTR
{
    partial class Seccion1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_comenzar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Temp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(11, 90);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(411, 266);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "<";
            this.chart3.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gráfica de posición";
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(11, 392);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(200, 186);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Energía Cinética";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Energía Potencial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chart2
            // 
            chartArea9.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chart2.Legends.Add(legend9);
            this.chart2.Location = new System.Drawing.Point(222, 392);
            this.chart2.Name = "chart2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart2.Series.Add(series9);
            this.chart2.Size = new System.Drawing.Size(200, 186);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "<";
            this.chart2.Click += new System.EventHandler(this.chart3_Click);
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(61, 11);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 20);
            this.txt_k.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "k:";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(61, 37);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(100, 20);
            this.txt_m.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "m:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_pos
            // 
            this.txt_pos.Location = new System.Drawing.Point(197, 12);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(100, 20);
            this.txt_pos.TabIndex = 6;
            this.txt_pos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "x(0):";
            // 
            // txt_vel
            // 
            this.txt_vel.Location = new System.Drawing.Point(197, 38);
            this.txt_vel.Name = "txt_vel";
            this.txt_vel.Size = new System.Drawing.Size(100, 20);
            this.txt_vel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ẋ(0):";
            // 
            // btn_comenzar
            // 
            this.btn_comenzar.Location = new System.Drawing.Point(303, 12);
            this.btn_comenzar.Name = "btn_comenzar";
            this.btn_comenzar.Size = new System.Drawing.Size(75, 21);
            this.btn_comenzar.TabIndex = 25;
            this.btn_comenzar.Text = "Comenzar";
            this.btn_comenzar.UseVisualStyleBackColor = true;
            this.btn_comenzar.Click += new System.EventHandler(this.btn_comenzar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Temp
            // 
            this.btn_Temp.Location = new System.Drawing.Point(303, 38);
            this.btn_Temp.Name = "btn_Temp";
            this.btn_Temp.Size = new System.Drawing.Size(75, 21);
            this.btn_Temp.TabIndex = 25;
            this.btn_Temp.Text = "Registrar T";
            this.btn_Temp.UseVisualStyleBackColor = true;
            this.btn_Temp.Click += new System.EventHandler(this.btn_Temp_Click);
            // 
            // Seccion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 590);
            this.Controls.Add(this.btn_Temp);
            this.Controls.Add(this.btn_comenzar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vel);
            this.Controls.Add(this.txt_pos);
            this.Controls.Add(this.txt_m);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart3);
            this.Name = "Seccion1";
            this.Text = "Seccion1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seccion1_FormClosing);
            this.Load += new System.EventHandler(this.Seccion1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_comenzar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Temp;
    }
}