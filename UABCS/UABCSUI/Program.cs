using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UABCSUI
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
            CSLibrary.GlobalConfig.InitializareConexiuni(true, true);
            //Application.Run(new PanouCompetitie());
            Application.Run(new AdaugaPremiuNou());
        }
    }
}
