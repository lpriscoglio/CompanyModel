using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Team15
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model.Azienda.GetInstance().Load(new Persistence.MockAziendaPersister());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Presentation.MainForm());
            Application.Run(new Presentation.LoginForm());
        }
    }
}
