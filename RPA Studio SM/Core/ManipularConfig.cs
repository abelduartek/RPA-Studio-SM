using System.IO;

namespace RPA_Studio_SM.Core
{
    class ManipularConfig
    {
        public static void inserirCaminho(string caminho)
        {

            StreamWriter temp = new StreamWriter(@"config.txt", false);

            string caminhoRPA = caminho;

            temp.WriteLine(caminhoRPA);

            temp.Close();

        }

        public static string retornoCaminho()
        {

            StreamReader temp = new StreamReader(@"config.txt");

            string retorno = temp.ReadLine();

            temp.Close();

            return retorno;
        }
    }
}
