using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sarasavi_library_management_system
{
    static class Program
    {
        public static string firstname, password;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new search_book());
        }
    }
}
