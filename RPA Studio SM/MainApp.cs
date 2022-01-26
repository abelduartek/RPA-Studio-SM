using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPA_Studio_SM.Core;
using System.Diagnostics;

namespace RPA_Studio_SM
{
    static class MainApp
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileInfo arquivoConfig = new FileInfo(@"config.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTelaPrincipal());
                   
        }
    }
}
