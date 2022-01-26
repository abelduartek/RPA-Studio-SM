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
            string caminhoArquivoConfig = GetRPAPath() + @"\RPAStudio.Wpf.exe.config";
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

            StreamWriter sw = null;

            try
            {
                 sw =  new StreamWriter(caminhoArquivoConfig);
                 
            }
            catch (System.UnauthorizedAccessException e)
            {
                MessageBox.Show("Erro! Pasta e arquivos não podem ser modificados!" + Environment.NewLine + "Por gentileza, realizar as permissões de edição do caminho: " + caminhoArquivoConfig);
            }
            finally
            {
                sw.Write(sb);
                sw.Close();
            }


            try
            {
                var retorno = System.Diagnostics.Process.Start(AlterarModo.GetRPAPath() + @"\RPAStudio.Wpf.exe");
            }
            catch
            { 
            }
            


        }

        public static string GetRPAPath() {

            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"Selbetti Tecnologia S.A\RPA Studio");
        }

    }
}
