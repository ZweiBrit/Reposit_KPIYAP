using System;
using System.Windows.Forms;

namespace WinFormsApp5 // ������� "OvalFormExample" �� "WinFormsApp5"
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ������� "OvalForm" �� "Form1"
        }
    }
}
