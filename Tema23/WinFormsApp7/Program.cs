using System;
using System.Windows.Forms;

namespace TwoFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SecondForm()); // Запускаем стартовую форму
        }
    }
}
