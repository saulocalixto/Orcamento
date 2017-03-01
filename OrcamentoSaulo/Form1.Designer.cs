namespace OrcamentoSaulo
{
    partial class OrcamentoSaulo
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
            this.SelecionarMes = new System.Windows.Forms.GroupBox();
            this.botaoNovoOrcamento = new System.Windows.Forms.Button();
            this.textoOrcamento = new System.Windows.Forms.Label();
            this.selecionarOrcamento = new System.Windows.Forms.ComboBox();
            this.textoBruto = new System.Windows.Forms.Label();
            this.totalDespesas = new System.Windows.Forms.Label();
            this.textoLiquido = new System.Windows.Forms.Label();
            this.brutoValue = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.GroupBox();
            this.botaoAddReceita = new System.Windows.Forms.Button();
            this.botaoVerDespesa = new System.Windows.Forms.Button();
            this.liquidoValue = new System.Windows.Forms.Label();
            this.despesasValue = new System.Windows.Forms.Label();
            this.SelecionarMes.SuspendLayout();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelecionarMes
            // 
            this.SelecionarMes.Controls.Add(this.botaoNovoOrcamento);
            this.SelecionarMes.Controls.Add(this.textoOrcamento);
            this.SelecionarMes.Controls.Add(this.selecionarOrcamento);
            this.SelecionarMes.Location = new System.Drawing.Point(13, 13);
            this.SelecionarMes.Name = "SelecionarMes";
            this.SelecionarMes.Size = new System.Drawing.Size(424, 100);
            this.SelecionarMes.TabIndex = 0;
            this.SelecionarMes.TabStop = false;
            this.SelecionarMes.Text = "Selecionar Mês";
            // 
            // botaoNovoOrcamento
            // 
            this.botaoNovoOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoNovoOrcamento.Location = new System.Drawing.Point(10, 70);
            this.botaoNovoOrcamento.Name = "botaoNovoOrcamento";
            this.botaoNovoOrcamento.Size = new System.Drawing.Size(102, 23);
            this.botaoNovoOrcamento.TabIndex = 2;
            this.botaoNovoOrcamento.Text = "Novo Orçamento";
            this.botaoNovoOrcamento.UseVisualStyleBackColor = true;
            this.botaoNovoOrcamento.Click += new System.EventHandler(this.botaoNovoOrcamento_Click);
            // 
            // textoOrcamento
            // 
            this.textoOrcamento.AutoSize = true;
            this.textoOrcamento.Location = new System.Drawing.Point(7, 46);
            this.textoOrcamento.Name = "textoOrcamento";
            this.textoOrcamento.Size = new System.Drawing.Size(59, 13);
            this.textoOrcamento.TabIndex = 1;
            this.textoOrcamento.Text = "Orçamento";
            // 
            // selecionarOrcamento
            // 
            this.selecionarOrcamento.FormattingEnabled = true;
            this.selecionarOrcamento.Location = new System.Drawing.Point(72, 43);
            this.selecionarOrcamento.Name = "selecionarOrcamento";
            this.selecionarOrcamento.Size = new System.Drawing.Size(346, 21);
            this.selecionarOrcamento.TabIndex = 0;
            this.selecionarOrcamento.SelectedIndexChanged += new System.EventHandler(this.selecionarOrcamento_SelectedIndexChanged);
            // 
            // textoBruto
            // 
            this.textoBruto.AutoSize = true;
            this.textoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBruto.Location = new System.Drawing.Point(7, 30);
            this.textoBruto.Name = "textoBruto";
            this.textoBruto.Size = new System.Drawing.Size(46, 17);
            this.textoBruto.TabIndex = 0;
            this.textoBruto.Text = "Bruto:";
            // 
            // totalDespesas
            // 
            this.totalDespesas.AutoSize = true;
            this.totalDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDespesas.Location = new System.Drawing.Point(7, 61);
            this.totalDespesas.Name = "totalDespesas";
            this.totalDespesas.Size = new System.Drawing.Size(75, 17);
            this.totalDespesas.TabIndex = 1;
            this.totalDespesas.Text = "Despesas:";
            // 
            // textoLiquido
            // 
            this.textoLiquido.AutoSize = true;
            this.textoLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLiquido.Location = new System.Drawing.Point(7, 92);
            this.textoLiquido.Name = "textoLiquido";
            this.textoLiquido.Size = new System.Drawing.Size(58, 17);
            this.textoLiquido.TabIndex = 2;
            this.textoLiquido.Text = "Líquido:";
            // 
            // brutoValue
            // 
            this.brutoValue.AutoSize = true;
            this.brutoValue.Location = new System.Drawing.Point(59, 32);
            this.brutoValue.Name = "brutoValue";
            this.brutoValue.Size = new System.Drawing.Size(13, 13);
            this.brutoValue.TabIndex = 3;
            this.brutoValue.Text = "--";
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.botaoAddReceita);
            this.Dados.Controls.Add(this.botaoVerDespesa);
            this.Dados.Controls.Add(this.liquidoValue);
            this.Dados.Controls.Add(this.despesasValue);
            this.Dados.Controls.Add(this.brutoValue);
            this.Dados.Controls.Add(this.textoLiquido);
            this.Dados.Controls.Add(this.totalDespesas);
            this.Dados.Controls.Add(this.textoBruto);
            this.Dados.Location = new System.Drawing.Point(13, 136);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(424, 163);
            this.Dados.TabIndex = 1;
            this.Dados.TabStop = false;
            this.Dados.Text = "Dados";
            // 
            // botaoAddReceita
            // 
            this.botaoAddReceita.Enabled = false;
            this.botaoAddReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAddReceita.Location = new System.Drawing.Point(6, 134);
            this.botaoAddReceita.Name = "botaoAddReceita";
            this.botaoAddReceita.Size = new System.Drawing.Size(115, 23);
            this.botaoAddReceita.TabIndex = 7;
            this.botaoAddReceita.Text = "Acrescentar Receita";
            this.botaoAddReceita.UseVisualStyleBackColor = true;
            this.botaoAddReceita.Click += new System.EventHandler(this.botaoAddReceita_Click);
            // 
            // botaoVerDespesa
            // 
            this.botaoVerDespesa.Enabled = false;
            this.botaoVerDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVerDespesa.Location = new System.Drawing.Point(316, 134);
            this.botaoVerDespesa.Name = "botaoVerDespesa";
            this.botaoVerDespesa.Size = new System.Drawing.Size(91, 23);
            this.botaoVerDespesa.TabIndex = 6;
            this.botaoVerDespesa.Text = "Ver Despesas";
            this.botaoVerDespesa.UseVisualStyleBackColor = true;
            this.botaoVerDespesa.Click += new System.EventHandler(this.botaoVerDespesa_Click);
            // 
            // liquidoValue
            // 
            this.liquidoValue.AutoSize = true;
            this.liquidoValue.Location = new System.Drawing.Point(69, 94);
            this.liquidoValue.Name = "liquidoValue";
            this.liquidoValue.Size = new System.Drawing.Size(13, 13);
            this.liquidoValue.TabIndex = 5;
            this.liquidoValue.Text = "--";
            // 
            // despesasValue
            // 
            this.despesasValue.AutoSize = true;
            this.despesasValue.Location = new System.Drawing.Point(88, 63);
            this.despesasValue.Name = "despesasValue";
            this.despesasValue.Size = new System.Drawing.Size(13, 13);
            this.despesasValue.TabIndex = 4;
            this.despesasValue.Text = "--";
            // 
            // OrcamentoSaulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(459, 325);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.SelecionarMes);
            this.Name = "OrcamentoSaulo";
            this.Text = "Orçamento Saulo";
            this.Load += new System.EventHandler(this.OrcamentoSaulo_Load);
            this.SelecionarMes.ResumeLayout(false);
            this.SelecionarMes.PerformLayout();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelecionarMes;
        private System.Windows.Forms.Label textoOrcamento;
        private System.Windows.Forms.ComboBox selecionarOrcamento;
        private System.Windows.Forms.Label textoBruto;
        private System.Windows.Forms.Label totalDespesas;
        private System.Windows.Forms.Label textoLiquido;
        private System.Windows.Forms.Label brutoValue;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.Label liquidoValue;
        private System.Windows.Forms.Label despesasValue;
        private System.Windows.Forms.Button botaoVerDespesa;
        private System.Windows.Forms.Button botaoNovoOrcamento;
        private System.Windows.Forms.Button botaoAddReceita;
    }
}

