
namespace RPA_Studio_SM
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPrincipal));
            this.lblSelectExecutionMode = new System.Windows.Forms.Label();
            this.btnAgentMode = new FontAwesome.Sharp.IconButton();
            this.btnStudioMode = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblSelectExecutionMode
            // 
            this.lblSelectExecutionMode.AutoSize = true;
            this.lblSelectExecutionMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectExecutionMode.ForeColor = System.Drawing.Color.White;
            this.lblSelectExecutionMode.Location = new System.Drawing.Point(12, 18);
            this.lblSelectExecutionMode.Name = "lblSelectExecutionMode";
            this.lblSelectExecutionMode.Size = new System.Drawing.Size(128, 15);
            this.lblSelectExecutionMode.TabIndex = 2;
            this.lblSelectExecutionMode.Text = "Select execution mode";
            // 
            // btnAgentMode
            // 
            this.btnAgentMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgentMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgentMode.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnAgentMode.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnAgentMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgentMode.IconSize = 40;
            this.btnAgentMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgentMode.Location = new System.Drawing.Point(12, 47);
            this.btnAgentMode.Name = "btnAgentMode";
            this.btnAgentMode.Size = new System.Drawing.Size(343, 61);
            this.btnAgentMode.TabIndex = 3;
            this.btnAgentMode.Text = "Agent Mode";
            this.btnAgentMode.UseVisualStyleBackColor = true;
            this.btnAgentMode.Click += new System.EventHandler(this.btnAgentMode_Click);
            // 
            // btnStudioMode
            // 
            this.btnStudioMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudioMode.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnStudioMode.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnStudioMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudioMode.IconSize = 40;
            this.btnStudioMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudioMode.Location = new System.Drawing.Point(12, 114);
            this.btnStudioMode.Name = "btnStudioMode";
            this.btnStudioMode.Size = new System.Drawing.Size(343, 61);
            this.btnStudioMode.TabIndex = 4;
            this.btnStudioMode.Text = "Studio Mode";
            this.btnStudioMode.UseVisualStyleBackColor = true;
            this.btnStudioMode.Click += new System.EventHandler(this.btnStudioMode_Click);
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(369, 202);
            this.Controls.Add(this.btnStudioMode);
            this.Controls.Add(this.lblSelectExecutionMode);
            this.Controls.Add(this.btnAgentMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPA Mode Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectExecutionMode;
        private FontAwesome.Sharp.IconButton btnAgentMode;
        private FontAwesome.Sharp.IconButton btnStudioMode;
    }
}

