namespace OrcamentoSaulo
{
    partial class novaDespesa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.Label();
            this.dataDespesa = new System.Windows.Forms.DateTimePicker();
            this.botaoAdd = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.dataDespesa);
            this.groupBox1.Controls.Add(this.botaoAdd);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.comboTipo);
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.labelValor);
            this.groupBox1.Controls.Add(this.LabelTipo);
            this.groupBox1.Controls.Add(this.labelDescricao);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Despesa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(13, 187);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(33, 13);
            this.data.TabIndex = 8;
            this.data.Text = "Data:";
            // 
            // dataDespesa
            // 
            this.dataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDespesa.Location = new System.Drawing.Point(75, 181);
            this.dataDespesa.Name = "dataDespesa";
            this.dataDespesa.Size = new System.Drawing.Size(178, 20);
            this.dataDespesa.TabIndex = 7;
            // 
            // botaoAdd
            // 
            this.botaoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdd.Location = new System.Drawing.Point(109, 222);
            this.botaoAdd.Name = "botaoAdd";
            this.botaoAdd.Size = new System.Drawing.Size(75, 23);
            this.botaoAdd.TabIndex = 6;
            this.botaoAdd.Text = "Adicionar";
            this.botaoAdd.UseVisualStyleBackColor = true;
            this.botaoAdd.Click += new System.EventHandler(this.botaoAdd_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(75, 142);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(178, 20);
            this.textValor.TabIndex = 5;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(75, 95);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(178, 21);
            this.comboTipo.TabIndex = 4;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(75, 51);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(178, 20);
            this.textDescricao.TabIndex = 3;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(10, 142);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor:";
            // 
            // LabelTipo
            // 
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Location = new System.Drawing.Point(10, 95);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(31, 13);
            this.LabelTipo.TabIndex = 1;
            this.LabelTipo.Text = "Tipo:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(10, 51);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Descrição:";
            // 
            // novaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.groupBox1);
            this.Name = "novaDespesa";
            this.Text = "novaDespesa";
            this.Load += new System.EventHandler(this.novaDespesa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Button botaoAdd;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DateTimePicker dataDespesa;
    }
}