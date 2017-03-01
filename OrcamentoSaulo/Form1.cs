using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace OrcamentoSaulo
{
    public partial class OrcamentoSaulo : Form
    {

        private List<Orcamento1> orcamentos;
        private Orcamento1 selecionada;
        CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");

        private void OrcamentoSaulo_Load(object sender, EventArgs e)
        {
            orcamentos = new List<Orcamento1>();
        }

        public void addOrcamento(Orcamento1 orcamento)
        {
            this.orcamentos.Add(orcamento);
            selecionarOrcamento.Items.Add(orcamento);
            MessageBox.Show("Orçamento adicionado com sucesso");

        }

        public OrcamentoSaulo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Dados_Enter(object sender, EventArgs e)
        {
    
        }

        private void botaoVerDespesa_Click(object sender, EventArgs e)
        {
            janelaDespesas despesas = new janelaDespesas(this);
            despesas.ShowDialog(this);
        }

        public Orcamento1 getSelecionada()
        {
            return selecionada;
        }

        private void botaoNovoOrcamento_Click(object sender, EventArgs e)
        {
            AddOrcamento adiconarOrcamento = new AddOrcamento(this);
            adiconarOrcamento.ShowDialog(this);
        }

        public void definirBruto()
        {
            brutoValue.Text = "R$ " + string.Format(ptBR, "{0:0,0.00}", selecionada.bruto);
            liquidoValue.Text = "R$ " + string.Format(ptBR, "{0:0,0.00}", selecionada.getLiquido());
            despesasValue.Text = "R$ " + string.Format(ptBR, "{0:0,0.00}", selecionada.getDespesasTotal());
        }

        private void selecionarOrcamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionada = (Orcamento1)selecionarOrcamento.SelectedItem;
            definirBruto();
            botaoVerDespesa.Enabled = true;
            botaoAddReceita.Enabled = true;
        }

        private void botaoAddReceita_Click(object sender, EventArgs e)
        {
            acrescentarReceita botaoAddReceita = new acrescentarReceita(this);
            botaoAddReceita.ShowDialog(this);
        }
    }
}
