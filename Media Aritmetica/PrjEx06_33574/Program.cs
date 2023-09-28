using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrjEx06_33574
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
            Application.Run(new frmEx06_33574());
        }
    }
}
