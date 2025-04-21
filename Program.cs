using System;
using System.Windows.Forms;

namespace Capitalis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MenuPrincipal()); // Aquí se lanza el formulario principal
        }
    }
}
