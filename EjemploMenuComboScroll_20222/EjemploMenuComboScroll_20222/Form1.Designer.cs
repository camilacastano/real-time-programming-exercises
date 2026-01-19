namespace EjemploMenuComboScroll_20222
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tcProcesamientoDatos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBorrarPapel = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnDibujarCirculo = new System.Windows.Forms.Button();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.pnlPapel = new System.Windows.Forms.Panel();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarDato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDatosIngresados = new System.Windows.Forms.ListBox();
            this.btnIngresarDato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpAnalisisDatos = new System.Windows.Forms.TabPage();
            this.tpGraficas = new System.Windows.Forms.TabPage();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGraficarAleatorio = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarSerie = new System.Windows.Forms.Button();
            this.cboGraficas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLeerFecha = new System.Windows.Forms.Button();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkSobreescribir = new System.Windows.Forms.CheckBox();
            this.tcProcesamientoDatos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            this.pnlIngresoDatos.SuspendLayout();
            this.tpGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProcesamientoDatos
            // 
            this.tcProcesamientoDatos.Controls.Add(this.tpDatos);
            this.tcProcesamientoDatos.Controls.Add(this.tabPage1);
            this.tcProcesamientoDatos.Controls.Add(this.tpAnalisisDatos);
            this.tcProcesamientoDatos.Controls.Add(this.tpGraficas);
            this.tcProcesamientoDatos.Location = new System.Drawing.Point(12, 132);
            this.tcProcesamientoDatos.Name = "tcProcesamientoDatos";
            this.tcProcesamientoDatos.SelectedIndex = 0;
            this.tcProcesamientoDatos.Size = new System.Drawing.Size(945, 605);
            this.tcProcesamientoDatos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBorrarPapel);
            this.tabPage1.Controls.Add(this.btnLinea);
            this.tabPage1.Controls.Add(this.btnDibujarCirculo);
            this.tabPage1.Controls.Add(this.btnDibujarLinea);
            this.tabPage1.Controls.Add(this.pnlPapel);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 558);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Graficos Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPapel
            // 
            this.btnBorrarPapel.Location = new System.Drawing.Point(43, 448);
            this.btnBorrarPapel.Name = "btnBorrarPapel";
            this.btnBorrarPapel.Size = new System.Drawing.Size(115, 36);
            this.btnBorrarPapel.TabIndex = 22;
            this.btnBorrarPapel.Text = "Borrar";
            this.btnBorrarPapel.UseVisualStyleBackColor = true;
            this.btnBorrarPapel.Click += new System.EventHandler(this.btnBorrarPapel_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(76, 162);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(59, 36);
            this.btnLinea.TabIndex = 21;
            this.btnLinea.Text = "/";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnDibujarCirculo
            // 
            this.btnDibujarCirculo.Location = new System.Drawing.Point(76, 204);
            this.btnDibujarCirculo.Name = "btnDibujarCirculo";
            this.btnDibujarCirculo.Size = new System.Drawing.Size(59, 36);
            this.btnDibujarCirculo.TabIndex = 20;
            this.btnDibujarCirculo.Text = "O";
            this.btnDibujarCirculo.UseVisualStyleBackColor = true;
            this.btnDibujarCirculo.Click += new System.EventHandler(this.btnDibujarCirculo_Click);
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(33, 88);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(158, 36);
            this.btnDibujarLinea.TabIndex = 19;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // pnlPapel
            // 
            this.pnlPapel.Location = new System.Drawing.Point(222, 43);
            this.pnlPapel.Name = "pnlPapel";
            this.pnlPapel.Size = new System.Drawing.Size(668, 473);
            this.pnlPapel.TabIndex = 0;
            this.pnlPapel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPapel_MouseClick);
            this.pnlPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPapel_MouseMove);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.chkSobreescribir);
            this.tpDatos.Controls.Add(this.pnlIngresoDatos);
            this.tpDatos.Controls.Add(this.btnAgregarGrupo);
            this.tpDatos.Controls.Add(this.cboGrupo);
            this.tpDatos.Controls.Add(this.label4);
            this.tpDatos.Location = new System.Drawing.Point(8, 39);
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatos.Size = new System.Drawing.Size(929, 558);
            this.tpDatos.TabIndex = 0;
            this.tpDatos.Text = "Datos";
            this.tpDatos.UseVisualStyleBackColor = true;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.Controls.Add(this.label3);
            this.pnlIngresoDatos.Controls.Add(this.btnEliminarDato);
            this.pnlIngresoDatos.Controls.Add(this.label2);
            this.pnlIngresoDatos.Controls.Add(this.lstDatosIngresados);
            this.pnlIngresoDatos.Controls.Add(this.btnIngresarDato);
            this.pnlIngresoDatos.Controls.Add(this.label1);
            this.pnlIngresoDatos.Controls.Add(this.txtDato);
            this.pnlIngresoDatos.Enabled = false;
            this.pnlIngresoDatos.Location = new System.Drawing.Point(35, 87);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(288, 456);
            this.pnlIngresoDatos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "[s]";
            // 
            // btnEliminarDato
            // 
            this.btnEliminarDato.Location = new System.Drawing.Point(65, 410);
            this.btnEliminarDato.Name = "btnEliminarDato";
            this.btnEliminarDato.Size = new System.Drawing.Size(158, 36);
            this.btnEliminarDato.TabIndex = 5;
            this.btnEliminarDato.Text = "Eliminar dato";
            this.btnEliminarDato.UseVisualStyleBackColor = true;
            this.btnEliminarDato.Click += new System.EventHandler(this.btnEliminarDato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos ingresados";
            // 
            // lstDatosIngresados
            // 
            this.lstDatosIngresados.FormattingEnabled = true;
            this.lstDatosIngresados.ItemHeight = 25;
            this.lstDatosIngresados.Location = new System.Drawing.Point(56, 183);
            this.lstDatosIngresados.Name = "lstDatosIngresados";
            this.lstDatosIngresados.Size = new System.Drawing.Size(178, 204);
            this.lstDatosIngresados.TabIndex = 3;
            // 
            // btnIngresarDato
            // 
            this.btnIngresarDato.Location = new System.Drawing.Point(65, 74);
            this.btnIngresarDato.Name = "btnIngresarDato";
            this.btnIngresarDato.Size = new System.Drawing.Size(158, 36);
            this.btnIngresarDato.TabIndex = 2;
            this.btnIngresarDato.Text = "Ingresar dato";
            this.btnIngresarDato.UseVisualStyleBackColor = true;
            this.btnIngresarDato.Click += new System.EventHandler(this.btnIngresarDato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(89, 14);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(150, 31);
            this.txtDato.TabIndex = 0;
            this.txtDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato_KeyPress);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Location = new System.Drawing.Point(284, 40);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(39, 41);
            this.btnAgregarGrupo.TabIndex = 9;
            this.btnAgregarGrupo.Text = "+";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(148, 41);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(121, 33);
            this.cboGrupo.TabIndex = 8;
            this.cboGrupo.SelectedIndexChanged += new System.EventHandler(this.cboGrupo_SelectedIndexChanged);
            this.cboGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboGrupo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo:";
            // 
            // tpAnalisisDatos
            // 
            this.tpAnalisisDatos.Location = new System.Drawing.Point(8, 39);
            this.tpAnalisisDatos.Name = "tpAnalisisDatos";
            this.tpAnalisisDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnalisisDatos.Size = new System.Drawing.Size(929, 558);
            this.tpAnalisisDatos.TabIndex = 1;
            this.tpAnalisisDatos.Text = "Analisis Datos";
            this.tpAnalisisDatos.UseVisualStyleBackColor = true;
            // 
            // tpGraficas
            // 
            this.tpGraficas.Controls.Add(this.cboTipo);
            this.tpGraficas.Controls.Add(this.label9);
            this.tpGraficas.Controls.Add(this.btnGraficarAleatorio);
            this.tpGraficas.Controls.Add(this.btnVerificar);
            this.tpGraficas.Controls.Add(this.txtPromedio);
            this.tpGraficas.Controls.Add(this.label8);
            this.tpGraficas.Controls.Add(this.txtValorMinimo);
            this.tpGraficas.Controls.Add(this.label7);
            this.tpGraficas.Controls.Add(this.txtValorMaximo);
            this.tpGraficas.Controls.Add(this.label6);
            this.tpGraficas.Controls.Add(this.btnEliminarSerie);
            this.tpGraficas.Controls.Add(this.cboGraficas);
            this.tpGraficas.Controls.Add(this.label5);
            this.tpGraficas.Controls.Add(this.chart1);
            this.tpGraficas.Location = new System.Drawing.Point(8, 39);
            this.tpGraficas.Name = "tpGraficas";
            this.tpGraficas.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraficas.Size = new System.Drawing.Size(929, 558);
            this.tpGraficas.TabIndex = 2;
            this.tpGraficas.Text = "Graficas";
            this.tpGraficas.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Pie",
            "Line",
            "Bar",
            "Column"});
            this.cboTipo.Location = new System.Drawing.Point(183, 43);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 33);
            this.cboTipo.TabIndex = 21;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo de grafica:";
            // 
            // btnGraficarAleatorio
            // 
            this.btnGraficarAleatorio.Location = new System.Drawing.Point(40, 454);
            this.btnGraficarAleatorio.Name = "btnGraficarAleatorio";
            this.btnGraficarAleatorio.Size = new System.Drawing.Size(158, 68);
            this.btnGraficarAleatorio.TabIndex = 19;
            this.btnGraficarAleatorio.Text = "Grafica Aleatoria";
            this.btnGraficarAleatorio.UseVisualStyleBackColor = true;
            this.btnGraficarAleatorio.Click += new System.EventHandler(this.btnGraficarAleatorio_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(40, 179);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(158, 36);
            this.btnVerificar.TabIndex = 18;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(158, 349);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(63, 31);
            this.txtPromedio.TabIndex = 17;
            this.txtPromedio.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Promedio";
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.Location = new System.Drawing.Point(158, 295);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.ReadOnly = true;
            this.txtValorMinimo.Size = new System.Drawing.Size(63, 31);
            this.txtValorMinimo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor minimo";
            // 
            // txtValorMaximo
            // 
            this.txtValorMaximo.Location = new System.Drawing.Point(158, 242);
            this.txtValorMaximo.Name = "txtValorMaximo";
            this.txtValorMaximo.ReadOnly = true;
            this.txtValorMaximo.Size = new System.Drawing.Size(63, 31);
            this.txtValorMaximo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor maximo";
            // 
            // btnEliminarSerie
            // 
            this.btnEliminarSerie.Location = new System.Drawing.Point(356, 58);
            this.btnEliminarSerie.Name = "btnEliminarSerie";
            this.btnEliminarSerie.Size = new System.Drawing.Size(158, 36);
            this.btnEliminarSerie.TabIndex = 11;
            this.btnEliminarSerie.Text = "Eliminar Serie";
            this.btnEliminarSerie.UseVisualStyleBackColor = true;
            this.btnEliminarSerie.Click += new System.EventHandler(this.btnEliminarSerie_Click);
            // 
            // cboGraficas
            // 
            this.cboGraficas.FormattingEnabled = true;
            this.cboGraficas.Location = new System.Drawing.Point(134, 103);
            this.cboGraficas.Name = "cboGraficas";
            this.cboGraficas.Size = new System.Drawing.Size(121, 33);
            this.cboGraficas.TabIndex = 10;
            this.cboGraficas.SelectedIndexChanged += new System.EventHandler(this.cboGraficas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grupo:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Eje horizontal";
            chartArea1.AxisY.Title = "u.a.";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(242, 128);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(669, 387);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAplicacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarAplicacionToolStripMenuItem
            // 
            this.cerrarAplicacionToolStripMenuItem.Name = "cerrarAplicacionToolStripMenuItem";
            this.cerrarAplicacionToolStripMenuItem.Size = new System.Drawing.Size(267, 36);
            this.cerrarAplicacionToolStripMenuItem.Text = "Cerrar aplicacion";
            this.cerrarAplicacionToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicacionToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(61, 36);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(454, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(403, 31);
            this.dtpFecha.TabIndex = 2;
            // 
            // btnLeerFecha
            // 
            this.btnLeerFecha.Location = new System.Drawing.Point(454, 80);
            this.btnLeerFecha.Name = "btnLeerFecha";
            this.btnLeerFecha.Size = new System.Drawing.Size(130, 42);
            this.btnLeerFecha.TabIndex = 3;
            this.btnLeerFecha.Text = "Aceptar";
            this.btnLeerFecha.UseVisualStyleBackColor = true;
            this.btnLeerFecha.Click += new System.EventHandler(this.btnLeerFecha_Click);
            // 
            // lblFechaSeleccionada
            // 
            this.lblFechaSeleccionada.AutoSize = true;
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(619, 97);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(70, 25);
            this.lblFechaSeleccionada.TabIndex = 4;
            this.lblFechaSeleccionada.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkSobreescribir
            // 
            this.chkSobreescribir.AutoSize = true;
            this.chkSobreescribir.Location = new System.Drawing.Point(350, 168);
            this.chkSobreescribir.Name = "chkSobreescribir";
            this.chkSobreescribir.Size = new System.Drawing.Size(171, 29);
            this.chkSobreescribir.TabIndex = 11;
            this.chkSobreescribir.Text = "Sobreescribir";
            this.chkSobreescribir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIngresarDato;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 773);
            this.Controls.Add(this.lblFechaSeleccionada);
            this.Controls.Add(this.btnLeerFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tcProcesamientoDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcProcesamientoDatos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            this.tpGraficas.ResumeLayout(false);
            this.tpGraficas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcProcesamientoDatos;
        private System.Windows.Forms.TabPage tpDatos;
        private System.Windows.Forms.TabPage tpAnalisisDatos;
        private System.Windows.Forms.TabPage tpGraficas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnIngresarDato;
        private System.Windows.Forms.Button btnEliminarDato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDatosIngresados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnLeerFecha;
        private System.Windows.Forms.Label lblFechaSeleccionada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cboGraficas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarSerie;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGraficarAleatorio;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlPapel;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.Button btnDibujarCirculo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnBorrarPapel;
        private System.Windows.Forms.CheckBox chkSobreescribir;
    }
}

