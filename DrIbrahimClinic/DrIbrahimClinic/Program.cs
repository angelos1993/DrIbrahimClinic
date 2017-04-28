using System;
using System.Windows.Forms;
using DrIbrahimClinic.PL;

namespace DrIbrahimClinic
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
            Application.Run(new FrmIndex());
        }
    }
}
