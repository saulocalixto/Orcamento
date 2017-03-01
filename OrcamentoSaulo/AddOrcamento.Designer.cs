namespace OrcamentoSaulo
{
    partial class AddOrcamento
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
            this.boxRenda = new System.Windows.Forms.TextBox();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.textoMes = new System.Windows.Forms.Label();
            this.textoRenda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.boxRenda);
            this.groupBox1.Controls.Add(this.botaoAdicionar);
            this.groupBox1.Controls.Add(this.comboMes);
            this.groupBox1.Controls.Add(this.textoMes);
            this.groupBox1.Controls.Add(this.textoRenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Orçamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // boxRenda
            // 
            this.boxRenda.Location = new System.Drawing.Point(80, 30);
            this.boxRenda.Name = "boxRenda";
            this.boxRenda.Size = new System.Drawing.Size(121, 20);
            this.boxRenda.TabIndex = 5;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(91, 127);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 23);
            this.botaoAdicionar.TabIndex = 4;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(80, 76);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(121, 21);
            this.comboMes.TabIndex = 2;
            this.comboMes.SelectedIndexChanged += new System.EventHandler(this.comboMes_SelectedIndexChanged);
            // 
            // textoMes
            // 
            this.textoMes.AutoSize = true;
            this.textoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMes.Location = new System.Drawing.Point(37, 76);
            this.textoMes.Name = "textoMes";
            this.textoMes.Size = new System.Drawing.Size(37, 16);
            this.textoMes.TabIndex = 1;
            this.textoMes.Text = "Mês:";
            // 
            // textoRenda
            // 
            this.textoRenda.AutoSize = true;
            this.textoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRenda.Location = new System.Drawing.Point(22, 35);
            this.textoRenda.Name = "textoRenda";
            this.textoRenda.Size = new System.Drawing.Size(52, 16);
            this.textoRenda.TabIndex = 0;
            this.textoRenda.Text = "Renda:";
            // 
            // AddOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrcamento";
            this.Text = "AddOrcamento";
            this.Load += new System.EventHandler(this.AddOrcamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Label textoMes;
        private System.Windows.Forms.Label textoRenda;
        private System.Windows.Forms.TextBox boxRenda;
    }
}