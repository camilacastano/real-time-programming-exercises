using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;

namespace proyectofinal_PTR
{
    public partial class Seccion4 : Form
    {

        public string RutaArchivo = Path.Combine(Application.StartupPath, "datos.txt");
        public string delimitador = ";";
        public string omitir = "<no aplica>";
        public void Cargar()
        {
            Tabla.Rows.Clear();
            StreamReader validar_usuario = new StreamReader(RutaArchivo);
            for(int i = 0;  validar_usuario.Peek() > -1; i++)
            {
                string usuario = validar_usuario.ReadLine();
                string[] datos_entrada = usuario.Split(Convert.ToChar(delimitador));
                if (listaUsuarios.SelectedItem.ToString() == "Todos")
                {
                    Tabla.Rows.Add(datos_entrada[1], datos_entrada[2], datos_entrada[3], datos_entrada[4], datos_entrada[5], datos_entrada[6], datos_entrada[7], datos_entrada[8], datos_entrada[9]);
                }
                if (datos_entrada[0] == listaUsuarios.SelectedItem.ToString())
                {
                    Tabla.Rows.Add(datos_entrada[1], datos_entrada[2], datos_entrada[3], datos_entrada[4], datos_entrada[5], datos_entrada[6], datos_entrada[7], datos_entrada[8], datos_entrada[9]);
                }
            }
            validar_usuario.Close();

        }
        public Seccion4()
        {
            InitializeComponent();
        }

        private void Seccion4_Load(object sender, EventArgs e)
        {
            string usuario = Menu_principal.usuario;
            string tipo_usuario = Menu_principal.tipo_usuario;
            this.Text = usuario;
            listaUsuarios.SelectedIndex = 0;

            string Ruta = Path.Combine(Application.StartupPath, "usuarios.txt");

            StreamReader usuarios = new StreamReader(Ruta);
            while (usuarios.Peek() > -1)
            {
                string nombre = usuarios.ReadLine();
                string[] datos = nombre.Split(Convert.ToChar(delimitador));
                listaUsuarios.Items.Add(datos[3]);
            }
            usuarios.Close();
            Cargar();
        }

        private void Seccion4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu_principal Carga = Owner as Menu_principal;
            Carga.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private static Excel.Workbook Libro = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet Hoja = null;
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fichero = new SaveFileDialog { Filter = @"Excel (*.xls)|*.xls" })
            {
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    StreamReader validar_usuario = new StreamReader(RutaArchivo);
                    MyApp = new Excel.Application();
                    MyApp.Visible = false;
                    Libro = MyApp.Workbooks.Add();
                    Hoja = (Excel.Worksheet)Libro.Sheets[1]; // Explicit cast is not required here
                    //ultimaFila = Hoja.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                    int j = 1;
                    while (validar_usuario.Peek() > 0)
                    {
                        string usuario = validar_usuario.ReadLine();
                        string[] datos_entrada = usuario.Split(Convert.ToChar(delimitador));
                        if (listaUsuarios.SelectedItem.ToString() == "Todos")
                        {
                            Hoja.Cells[1, 1] = "Usuario";
                            Hoja.Cells[1, 2] = "k1";
                            Hoja.Cells[1, 3] = "m1";
                            Hoja.Cells[1, 4] = "pos1";
                            Hoja.Cells[1, 5] = "vel1";
                            Hoja.Cells[1, 6] = "b";
                            Hoja.Cells[1, 7] = "k2";
                            Hoja.Cells[1, 8] = "m2";
                            Hoja.Cells[1, 9] = "pos2";
                            Hoja.Cells[1, 10] = "vel2";
                            for (int i = 1; i < 11; i++)
                                Hoja.Cells[j+1, i] = datos_entrada[i-1];
                            j++;
                        }
                        if (datos_entrada[0] == listaUsuarios.SelectedItem.ToString())
                        {
                            Hoja.Cells[1, 1] = "k1";
                            Hoja.Cells[1, 2] = "m1";
                            Hoja.Cells[1, 3] = "pos1";
                            Hoja.Cells[1, 4] = "vel1";
                            Hoja.Cells[1, 5] = "b";
                            Hoja.Cells[1, 6] = "k2";
                            Hoja.Cells[1, 7] = "m2";
                            Hoja.Cells[1, 8] = "pos2";
                            Hoja.Cells[1, 9] = "vel2";
                            for (int i = 1; i < 10; i++)
                                Hoja.Cells[j+1, i] = datos_entrada[i];
                            j++;
                        }
                    }
                    validar_usuario.Close();

                    Libro.SaveAs(fichero.FileName);
                    Libro.Close();
                    MyApp.Quit();
                }
            }
        }
    }
}
