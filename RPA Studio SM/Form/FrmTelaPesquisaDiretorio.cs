using RPA_Studio_SM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA_Studio_SM
{
    public partial class FrmTelaPesquisaDiretorio : Form
    {
        public FrmTelaPesquisaDiretorio()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se foi apertado OK na tela de pesquisa de diretório, salvando o caminho na variável e setando no elemento txtDiretorio
            if (pesquisaPasta.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoDiretorio.Text = pesquisaPasta.SelectedPath + @"\";
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Verificando se o caminho selecionado não é vazio ou nulo
            if (String.IsNullOrEmpty(txtCaminhoDiretorio.Text))
            {
                MessageBox.Show("O caminho do RPA não foi definido!");
            }
            else
            {
                //Verificando se o arquivo de configuração do Agent existe no diretório selecionado
                if (File.Exists(txtCaminhoDiretorio.Text + "RPAStudio.Wpf.exe.config"))
                {
                    //Gravando o caminho no arquivo config.txt
                    ManipularConfig.inserirCaminho(txtCaminhoDiretorio.Text);
                    MessageBox.Show("Diretório confirmado, você será redirecionado para a seleção de modos do RPA!");

                    //Fechando a tela de procura do caminho e abrindo a tela principal
                    FrmTelaPrincipal telaPrincipal = new FrmTelaPrincipal();
                    this.Hide();
                    telaPrincipal.Show();

                }
                else
                {
                    MessageBox.Show("O caminho selecionado não consta o arquivo RPAStudio.Wpf.ext.config");
                    txtCaminhoDiretorio.Clear();
                }
            }

        }

    }
}
