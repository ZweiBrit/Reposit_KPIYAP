using System;
using System.Windows.Forms;

namespace WinFormsApp5 // Заменим "OvalFormExample" на "WinFormsApp5"
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Заменим "OvalForm" на "Form1"
        }
    }
}
