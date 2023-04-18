using H_Gates_Managment__System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Gates_Managment__System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginPage());
            Application.Run(new MainPage());
           Application.Run(new PatientsEntry());
            Application.Run(new PatientList());
           Application.Run(new IntakePage());
        }
    }
}


