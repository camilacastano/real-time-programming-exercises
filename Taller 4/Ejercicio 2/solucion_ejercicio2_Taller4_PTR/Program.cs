using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace solucion_ejercicio2_Taller4_PTR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Triki());
        }
    }
}
