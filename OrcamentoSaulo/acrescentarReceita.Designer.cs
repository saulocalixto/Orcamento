namespace OrcamentoSaulo
{
    partial class acrescentarReceita
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
            this.botaoAcrescentar = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoAcrescentar
            // 
            this.botaoAcrescentar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAcrescentar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoAcrescentar.Location = new System.Drawing.Point(88, 47);
            this.botaoAcrescentar.Name = "botaoAcrescentar";
            this.botaoAcrescentar.Size = new System.Drawing.Size(83, 23);
            this.botaoAcrescentar.TabIndex = 0;
            this.botaoAcrescentar.Text = "Adicionar";
            this.botaoAcrescentar.UseVisualStyleBackColor = false;
            this.botaoAcrescentar.Click += new System.EventHandler(this.botaoAcrescentar_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(88, 21);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(83, 20);
            this.textBoxValor.TabIndex = 1;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(39, 22);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(43, 16);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor:";
            // 
            // acrescentarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(263, 93);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.botaoAcrescentar);
            this.Name = "acrescentarReceita";
            this.Text = "Adicionar Receita";
            this.Load += new System.EventHandler(this.acrescentarReceita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoAcrescentar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelValor;
    }
}