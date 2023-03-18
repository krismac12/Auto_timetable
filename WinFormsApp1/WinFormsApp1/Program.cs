using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (XML.Check())
            {
                Application.Run(new Main_Form());
            }
            else
            {
                Application.Run(new login_Form());
                //Application.Run(new Main_Form());
                //Application.Run(new Home_Form());


            }

            //HelperFunctions.Test();
        }
    }
}
