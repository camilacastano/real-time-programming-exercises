namespace proyectofinal_PTR
{
    partial class Seccion2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_k1 = new System.Windows.Forms.Label();
            this.lbl_k2 = new System.Windows.Forms.Label();
            this.lbl_m1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_pos1 = new System.Windows.Forms.Label();
            this.lbl_vel1 = new System.Windows.Forms.Label();
            this.txt_k1 = new System.Windows.Forms.TextBox();
            this.txt_k2 = new System.Windows.Forms.TextBox();
            this.txt_m1 = new System.Windows.Forms.TextBox();
            this.txt_m2 = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_pos1 = new System.Windows.Forms.TextBox();
            this.txt_vel1 = new System.Windows.Forms.TextBox();
            this.btn_comenzar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_vel2 = new System.Windows.Forms.TextBox();
            this.txt_pos2 = new System.Windows.Forms.TextBox();
            this.lbl_vel2 = new System.Windows.Forms.Label();
            this.lbl_pos2 = new System.Windows.Forms.Label();
            this.btn_tiempoaplitud = new System.Windows.Forms.Label();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(124, 293);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Energia Cinetica";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(307, 179);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lbl_k1
            // 
            this.lbl_k1.AutoSize = true;
            this.lbl_k1.Location = new System.Drawing.Point(20, 103);
            this.lbl_k1.Name = "lbl_k1";
            this.lbl_k1.Size = new System.Drawing.Size(29, 13);
            this.lbl_k1.TabIndex = 3;
            this.lbl_k1.Text = "K_1:";
            // 
            // lbl_k2
            // 
            this.lbl_k2.AutoSize = true;
            this.lbl_k2.Location = new System.Drawing.Point(22, 207);
            this.lbl_k2.Name = "lbl_k2";
            this.lbl_k2.Size = new System.Drawing.Size(29, 13);
            this.lbl_k2.TabIndex = 4;
            this.lbl_k2.Text = "K_2:";
            // 
            // lbl_m1
            // 
            this.lbl_m1.AutoSize = true;
            this.lbl_m1.Location = new System.Drawing.Point(18, 129);
            this.lbl_m1.Name = "lbl_m1";
            this.lbl_m1.Size = new System.Drawing.Size(31, 13);
            this.lbl_m1.TabIndex = 5;
            this.lbl_m1.Text = "M_1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "M_2:";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(32, 311);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(17, 13);
            this.lbl_b.TabIndex = 7;
            this.lbl_b.Text = "B:";
            // 
            // lbl_pos1
            // 
            this.lbl_pos1.AutoSize = true;
            this.lbl_pos1.Location = new System.Drawing.Point(16, 155);
            this.lbl_pos1.Name = "lbl_pos1";
            this.lbl_pos1.Size = new System.Drawing.Size(33, 13);
            this.lbl_pos1.TabIndex = 8;
            this.lbl_pos1.Text = "x1(0):";
            // 
            // lbl_vel1
            // 
            this.lbl_vel1.AutoSize = true;
            this.lbl_vel1.Location = new System.Drawing.Point(16, 181);
            this.lbl_vel1.Name = "lbl_vel1";
            this.lbl_vel1.Size = new System.Drawing.Size(33, 13);
            this.lbl_vel1.TabIndex = 9;
            this.lbl_vel1.Text = "ẋ1(0):";
            this.lbl_vel1.Click += new System.EventHandler(this.lbl_vel1_Click);
            // 
            // txt_k1
            // 
            this.txt_k1.Location = new System.Drawing.Point(55, 99);
            this.txt_k1.Name = "txt_k1";
            this.txt_k1.Size = new System.Drawing.Size(63, 20);
            this.txt_k1.TabIndex = 10;
            this.txt_k1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k1_KeyPress);
            // 
            // txt_k2
            // 
            this.txt_k2.Location = new System.Drawing.Point(55, 203);
            this.txt_k2.Name = "txt_k2";
            this.txt_k2.Size = new System.Drawing.Size(63, 20);
            this.txt_k2.TabIndex = 11;
            this.txt_k2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k2_KeyPress);
            // 
            // txt_m1
            // 
            this.txt_m1.Location = new System.Drawing.Point(55, 125);
            this.txt_m1.Name = "txt_m1";
            this.txt_m1.Size = new System.Drawing.Size(63, 20);
            this.txt_m1.TabIndex = 12;
            this.txt_m1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_m1_KeyPress);
            // 
            // txt_m2
            // 
            this.txt_m2.Location = new System.Drawing.Point(55, 230);
            this.txt_m2.Name = "txt_m2";
            this.txt_m2.Size = new System.Drawing.Size(63, 20);
            this.txt_m2.TabIndex = 13;
            this.txt_m2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_m2_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(55, 308);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(63, 20);
            this.txt_b.TabIndex = 14;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            // 
            // txt_pos1
            // 
            this.txt_pos1.Location = new System.Drawing.Point(55, 151);
            this.txt_pos1.Name = "txt_pos1";
            this.txt_pos1.Size = new System.Drawing.Size(63, 20);
            this.txt_pos1.TabIndex = 15;
            this.txt_pos1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pos_KeyPress);
            // 
            // txt_vel1
            // 
            this.txt_vel1.Location = new System.Drawing.Point(55, 177);
            this.txt_vel1.Name = "txt_vel1";
            this.txt_vel1.Size = new System.Drawing.Size(63, 20);
            this.txt_vel1.TabIndex = 16;
            this.txt_vel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vel_KeyPress);
            // 
            // btn_comenzar
            // 
            this.btn_comenzar.Location = new System.Drawing.Point(25, 367);
            this.btn_comenzar.Name = "btn_comenzar";
            this.btn_comenzar.Size = new System.Drawing.Size(75, 25);
            this.btn_comenzar.TabIndex = 17;
            this.btn_comenzar.Text = "Comenzar";
            this.btn_comenzar.UseVisualStyleBackColor = true;
            this.btn_comenzar.Click += new System.EventHandler(this.btn_comenzar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(437, 293);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Energia Potencial";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(281, 179);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart2";
            // 
            // txt_vel2
            // 
            this.txt_vel2.Location = new System.Drawing.Point(55, 282);
            this.txt_vel2.Name = "txt_vel2";
            this.txt_vel2.Size = new System.Drawing.Size(63, 20);
            this.txt_vel2.TabIndex = 23;
            // 
            // txt_pos2
            // 
            this.txt_pos2.Location = new System.Drawing.Point(55, 256);
            this.txt_pos2.Name = "txt_pos2";
            this.txt_pos2.Size = new System.Drawing.Size(63, 20);
            this.txt_pos2.TabIndex = 22;
            // 
            // lbl_vel2
            // 
            this.lbl_vel2.AutoSize = true;
            this.lbl_vel2.Location = new System.Drawing.Point(18, 286);
            this.lbl_vel2.Name = "lbl_vel2";
            this.lbl_vel2.Size = new System.Drawing.Size(33, 13);
            this.lbl_vel2.TabIndex = 21;
            this.lbl_vel2.Text = "ẋ2(0):";
            // 
            // lbl_pos2
            // 
            this.lbl_pos2.AutoSize = true;
            this.lbl_pos2.Location = new System.Drawing.Point(18, 260);
            this.lbl_pos2.Name = "lbl_pos2";
            this.lbl_pos2.Size = new System.Drawing.Size(33, 13);
            this.lbl_pos2.TabIndex = 20;
            this.lbl_pos2.Text = "x2(0):";
            // 
            // btn_tiempoaplitud
            // 
            this.btn_tiempoaplitud.AutoSize = true;
            this.btn_tiempoaplitud.Location = new System.Drawing.Point(4, 337);
            this.btn_tiempoaplitud.Name = "btn_tiempoaplitud";
            this.btn_tiempoaplitud.Size = new System.Drawing.Size(45, 13);
            this.btn_tiempoaplitud.TabIndex = 25;
            this.btn_tiempoaplitud.Text = "Tiempo:";
            this.btn_tiempoaplitud.Click += new System.EventHandler(this.btn_tiempoaplitud_Click);
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(55, 334);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(63, 20);
            this.txt_Tiempo.TabIndex = 26;
            this.txt_Tiempo.TextChanged += new System.EventHandler(this.txt_Tiempo_TextChanged);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.Location = new System.Drawing.Point(43, 395);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(35, 13);
            this.lbl_tiempo.TabIndex = 27;
            this.lbl_tiempo.Text = "label1";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(124, 25);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "x1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "x2";
            this.chart3.Series.Add(series3);
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(594, 244);
            this.chart3.TabIndex = 28;
            this.chart3.Text = "chartpos";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Energía Cinética";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Energía Potencial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gráfica de posición";
            // 
            // Seccion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.txt_Tiempo);
            this.Controls.Add(this.btn_tiempoaplitud);
            this.Controls.Add(this.txt_vel2);
            this.Controls.Add(this.txt_pos2);
            this.Controls.Add(this.lbl_vel2);
            this.Controls.Add(this.lbl_pos2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btn_comenzar);
            this.Controls.Add(this.txt_vel1);
            this.Controls.Add(this.txt_pos1);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_m2);
            this.Controls.Add(this.txt_m1);
            this.Controls.Add(this.txt_k2);
            this.Controls.Add(this.txt_k1);
            this.Controls.Add(this.lbl_vel1);
            this.Controls.Add(this.lbl_pos1);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_m1);
            this.Controls.Add(this.lbl_k2);
            this.Controls.Add(this.lbl_k1);
            this.Controls.Add(this.chart1);
            this.Name = "Seccion2";
            this.Text = "Seccion2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Seccion2_FormClosing);
            this.Load += new System.EventHandler(this.Seccion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_k1;
        private System.Windows.Forms.Label lbl_k2;
        private System.Windows.Forms.Label lbl_m1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_pos1;
        private System.Windows.Forms.Label lbl_vel1;
        private System.Windows.Forms.TextBox txt_k1;
        private System.Windows.Forms.TextBox txt_k2;
        private System.Windows.Forms.TextBox txt_m1;
        private System.Windows.Forms.TextBox txt_m2;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_pos1;
        private System.Windows.Forms.TextBox txt_vel1;
        private System.Windows.Forms.Button btn_comenzar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox txt_vel2;
        private System.Windows.Forms.TextBox txt_pos2;
        private System.Windows.Forms.Label lbl_vel2;
        private System.Windows.Forms.Label lbl_pos2;
        private System.Windows.Forms.Label btn_tiempoaplitud;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}