using RPA_Studio_SM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA_Studio_SM
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgentMode_Click(object sender, EventArgs e)
        {
            AlterarModo.AlterandoModo("Agent");
        }

        private void btnStudioMode_Click(object sender, EventArgs e)
        {
            AlterarModo.AlterandoModo("Studio");
        }
    }
}
