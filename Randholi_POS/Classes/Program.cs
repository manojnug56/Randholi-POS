using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randholi_POS
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
            //Application.Run(new frm_login());
            //Application.Run(new frm_dashboard());
            //Application.Run(new frm_order());

            //Application.Run(new frm_utility());
            Application.Run(new frm_billing());
            //Application.Run(new frm_reports());

           // Application.Run(new frm_calculator());


        }
    }
}
