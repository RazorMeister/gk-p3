using System;
using System.Windows.Forms;

namespace gk_p3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}