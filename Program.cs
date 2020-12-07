﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEParaPeliculas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMenu());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
