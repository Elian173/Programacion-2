using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EjercicioGuia28
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Dictionary<int, string> palabras = new Dictionary<int, string>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}