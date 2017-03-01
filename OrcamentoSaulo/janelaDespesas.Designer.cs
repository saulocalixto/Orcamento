namespace OrcamentoSaulo
{
    partial class janelaDespesas
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
            this.verDespesasGroupBox = new System.Windows.Forms.GroupBox();
            this.novaDespesaBotao = new System.Windows.Forms.Button();
            this.comboDespesas = new System.Windows.Forms.ComboBox();
            this.textDespesas = new System.Windows.Forms.Label();
            this.detalhesgroupBox = new System.Windows.Forms.GroupBox();
            this.valueData = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.valueValor = new System.Windows.Forms.Label();
            this.valueDescricao = new System.Windows.Forms.Label();
            this.valueTipo = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.verDespesasGroupBox.SuspendLayout();
            this.detalhesgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // verDespesasGroupBox
            // 
            this.verDespesasGroupBox.Controls.Add(this.novaDespesaBotao);
            this.verDespesasGroupBox.Controls.Add(this.comboDespesas);
            this.verDespesasGroupBox.Controls.Add(this.textDespesas);
            this.verDespesasGroupBox.Location = new System.Drawing.Point(13, 13);
            this.verDespesasGroupBox.Name = "verDespesasGroupBox";
            this.verDespesasGroupBox.Size = new System.Drawing.Size(259, 90);
            this.verDespesasGroupBox.TabIndex = 0;
            this.verDespesasGroupBox.TabStop = false;
            this.verDespesasGroupBox.Text = "Ver Despesas";
            // 
            // novaDespesaBotao
            // 
            this.novaDespesaBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaDespesaBotao.Location = new System.Drawing.Point(10, 61);
            this.novaDespesaBotao.Name = "novaDespesaBotao";
            this.novaDespesaBotao.Size = new System.Drawing.Size(92, 23);
            this.novaDespesaBotao.TabIndex = 2;
            this.novaDespesaBotao.Text = "Nova Despesa";
            this.novaDespesaBotao.UseVisualStyleBackColor = true;
            this.novaDespesaBotao.Click += new System.EventHandler(this.novaDespesaBotao_Click);
            // 
            // comboDespesas
            // 
            this.comboDespesas.FormattingEnabled = true;
            this.comboDespesas.Location = new System.Drawing.Point(65, 20);
            this.comboDespesas.MaxDropDownItems = 100;
            this.comboDespesas.Name = "comboDespesas";
            this.comboDespesas.Size = new System.Drawing.Size(188, 21);
            this.comboDespesas.TabIndex = 1;
            this.comboDespesas.SelectedIndexChanged += new System.EventHandler(this.comboDespesas_SelectedIndexChanged);
            // 
            // textDespesas
            // 
            this.textDespesas.AutoSize = true;
            this.textDespesas.Location = new System.Drawing.Point(7, 23);
            this.textDespesas.Name = "textDespesas";
            this.textDespesas.Size = new System.Drawing.Size(52, 13);
            this.textDespesas.TabIndex = 0;
            this.textDespesas.Text = "Despesa:";
            // 
            // detalhesgroupBox
            // 
            this.detalhesgroupBox.Controls.Add(this.valueData);
            this.detalhesgroupBox.Controls.Add(this.data);
            this.detalhesgroupBox.Controls.Add(this.valueValor);
            this.detalhesgroupBox.Controls.Add(this.valueDescricao);
            this.detalhesgroupBox.Controls.Add(this.valueTipo);
            this.detalhesgroupBox.Controls.Add(this.valor);
            this.detalhesgroupBox.Controls.Add(this.descricao);
            this.detalhesgroupBox.Controls.Add(this.texto);
            this.detalhesgroupBox.Location = new System.Drawing.Point(13, 125);
            this.detalhesgroupBox.Name = "detalhesgroupBox";
            this.detalhesgroupBox.Size = new System.Drawing.Size(259, 124);
            this.detalhesgroupBox.TabIndex = 1;
            this.detalhesgroupBox.TabStop = false;
            this.detalhesgroupBox.Text = "Detalhes";
            // 
            // valueData
            // 
            this.valueData.AutoSize = true;
            this.valueData.Location = new System.Drawing.Point(49, 97);
            this.valueData.Name = "valueData";
            this.valueData.Size = new System.Drawing.Size(13, 13);
            this.valueData.TabIndex = 7;
            this.valueData.Text = "--";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(10, 97);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 6;
            this.data.Text = "Data:";
            // 
            // valueValor
            // 
            this.valueValor.AutoSize = true;
            this.valueValor.Location = new System.Drawing.Point(53, 69);
            this.valueValor.Name = "valueValor";
            this.valueValor.Size = new System.Drawing.Size(13, 13);
            this.valueValor.TabIndex = 5;
            this.valueValor.Text = "--";
            // 
            // valueDescricao
            // 
            this.valueDescricao.AutoSize = true;
            this.valueDescricao.Location = new System.Drawing.Point(74, 43);
            this.valueDescricao.Name = "valueDescricao";
            this.valueDescricao.Size = new System.Drawing.Size(13, 13);
            this.valueDescricao.TabIndex = 4;
            this.valueDescricao.Text = "--";
            // 
            // valueTipo
            // 
            this.valueTipo.AutoSize = true;
            this.valueTipo.Location = new System.Drawing.Point(48, 20);
            this.valueTipo.Name = "valueTipo";
            this.valueTipo.Size = new System.Drawing.Size(13, 13);
            this.valueTipo.TabIndex = 3;
            this.valueTipo.Text = "--";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(10, 69);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(34, 13);
            this.valor.TabIndex = 2;
            this.valor.Text = "Valor:";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(10, 43);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(58, 13);
            this.descricao.TabIndex = 1;
            this.descricao.Text = "Descrição:";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(10, 20);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(31, 13);
            this.texto.TabIndex = 0;
            this.texto.Text = "Tipo:";
            // 
            // janelaDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.detalhesgroupBox);
            this.Controls.Add(this.verDespesasGroupBox);
            this.Name = "janelaDespesas";
            this.Text = "janelaDespesas";
            this.Load += new System.EventHandler(this.janelaDespesas_Load);
            this.verDespesasGroupBox.ResumeLayout(false);
            this.verDespesasGroupBox.PerformLayout();
            this.detalhesgroupBox.ResumeLayout(false);
            this.detalhesgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox verDespesasGroupBox;
        private System.Windows.Forms.Button novaDespesaBotao;
        private System.Windows.Forms.ComboBox comboDespesas;
        private System.Windows.Forms.Label textDespesas;
        private System.Windows.Forms.GroupBox detalhesgroupBox;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label valueValor;
        private System.Windows.Forms.Label valueDescricao;
        private System.Windows.Forms.Label valueTipo;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label valueData;
    }
}