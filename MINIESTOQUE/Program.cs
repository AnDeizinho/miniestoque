using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MINIESTOQUE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool Conains(this string strprocurado, string comp, StringComparison Case)
        {
            if (!string.IsNullOrEmpty(strprocurado))
                return strprocurado.IndexOf(comp, Case)>=0;
            else
                return false;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
