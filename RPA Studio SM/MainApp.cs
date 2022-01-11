using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            switch (true)
            {

                case true when (arquivoConfig.Length <= 0):
                    Application.Run(new FrmTelaPesquisaDiretorio());
                    break;
                case true when (File.Exists(@"config.txt" + "RPAStudio.Wpf.exe.config")):
                    Application.Run(new FrmTelaPrincipal());
                    break;
                default:
                    Application.Run(new FrmTelaPesquisaDiretorio());
                    break;


            }
        }
    }
}
