
namespace RPA_Studio_SM
{
    partial class FrmTelaPesquisaDiretorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPesquisaDiretorio));
            this.lblDiretorioRPA = new System.Windows.Forms.Label();
            this.txtCaminhoDiretorio = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.btnConfirmar = new FontAwesome.Sharp.IconButton();
            this.lblAvisoPrimeiroUso = new System.Windows.Forms.Label();
            this.pesquisaPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblDiretorioRPA
            // 
            this.lblDiretorioRPA.AutoSize = true;
            this.lblDiretorioRPA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorioRPA.ForeColor = System.Drawing.Color.White;
            this.lblDiretorioRPA.Location = new System.Drawing.Point(12, 41);
            this.lblDiretorioRPA.Name = "lblDiretorioRPA";
            this.lblDiretorioRPA.Size = new System.Drawing.Size(92, 17);
            this.lblDiretorioRPA.TabIndex = 0;
            this.lblDiretorioRPA.Text = "Diretório RPA:";
            // 
            // txtCaminhoDiretorio
            // 
            this.txtCaminhoDiretorio.Location = new System.Drawing.Point(125, 41);
            this.txtCaminhoDiretorio.Name = "txtCaminhoDiretorio";
            this.txtCaminhoDiretorio.Size = new System.Drawing.Size(358, 20);
            this.txtCaminhoDiretorio.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.White;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 20;
            this.btnPesquisar.Location = new System.Drawing.Point(489, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 31);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnConfirmar.IconColor = System.Drawing.Color.Green;
            this.btnConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmar.IconSize = 20;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(125, 81);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(122, 25);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAvisoPrimeiroUso
            // 
            this.lblAvisoPrimeiroUso.AutoSize = true;
            this.lblAvisoPrimeiroUso.ForeColor = System.Drawing.Color.White;
            this.lblAvisoPrimeiroUso.Location = new System.Drawing.Point(94, 148);
            this.lblAvisoPrimeiroUso.Name = "lblAvisoPrimeiroUso";
            this.lblAvisoPrimeiroUso.Size = new System.Drawing.Size(378, 13);
            this.lblAvisoPrimeiroUso.TabIndex = 4;
            this.lblAvisoPrimeiroUso.Text = "Obs: Está tela irá aparecer uma única vez ou se o diretório do RPA for alterado";
            // 
            // FrmTelaPesquisaDiretorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(582, 170);
            this.Controls.Add(this.lblAvisoPrimeiroUso);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCaminhoDiretorio);
            this.Controls.Add(this.lblDiretorioRPA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelaPesquisaDiretorio";
            this.Text = "RPA Mode Selector - Atualização de Diretório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiretorioRPA;
        private System.Windows.Forms.TextBox txtCaminhoDiretorio;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private FontAwesome.Sharp.IconButton btnConfirmar;
        private System.Windows.Forms.Label lblAvisoPrimeiroUso;
        private System.Windows.Forms.FolderBrowserDialog pesquisaPasta;
    }
}