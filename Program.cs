using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Deepak_Xerox
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
            Application.Run(new Login());
           // Application.Run(new frmReportViewer());
           //Application.Run(new View_Billing());
            //Application.Run(new Form1());
        }
    }
}
