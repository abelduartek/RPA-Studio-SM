using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA_Studio_SM.Core
{
	class AlterarModo
	{
        public static void AlterandoModo(string modo)
        {
            Console.WriteLine("CAMINHO: " + ManipularConfig.retornoCaminho());
            string caminhoArquivoConfig = ManipularConfig.retornoCaminho() + "RPAStudio.Wpf.exe.config";
            Console.WriteLine(caminhoArquivoConfig);

            StreamReader sr = new StreamReader(caminhoArquivoConfig);
            StringBuilder sb = new StringBuilder();


            string valorNovo;

            if (modo == "Agent")
            {
                valorNovo = @"<add key=""IsAgent"" value=""true"" />";
            }
            else
            {
                valorNovo = @"<add key=""IsAgent"" value=""false"" />";
            }

            //Código pode ser melhorado realizando primeiro a verificação em qual estado está o config do RPA
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();

                if (s.Contains("IsAgent"))
                {
                    Console.WriteLine(s);
                    s = s.Replace(s, valorNovo);
                }

                sb.AppendLine(s);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(caminhoArquivoConfig);
            sw.Write(sb);

            sw.Close();

            System.Diagnostics.Process.Start(ManipularConfig.retornoCaminho() + "RPAStudio.Wpf.exe");
            Application.Exit();


        }

    }
}
