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

        private void btnAgentMode_MouseEnter(object sender, EventArgs e)
        {
            btnAgentMode.IconColor = System.Drawing.Color.White;
        }

        private void btnAgentMode_MouseLeave(object sender, EventArgs e)
        {
            btnAgentMode.IconColor = System.Drawing.SystemColors.Highlight;
        }

        private void btnStudioMode_MouseEnter(object sender, EventArgs e)
        {
            btnStudioMode.IconColor = System.Drawing.Color.White;
        }

        private void btnStudioMode_MouseLeave(object sender, EventArgs e)
        {
            btnStudioMode.IconColor = System.Drawing.SystemColors.Highlight;
        }
    }
}