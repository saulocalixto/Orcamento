using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoSaulo
{
    public partial class janelaDespesas : Form
    {
        CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");
        private OrcamentoSaulo formPrincipal;
        Despesa selecionada = new Despesa();

        public janelaDespesas(OrcamentoSaulo formPrincipal)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.formPrincipal = formPrincipal;
        }

        public void addDespesa(Despesa despesa)
        {

            this.formPrincipal.getSelecionada().setDespesas(despesa);
            comboDespesas.Items.Add(despesa);

            OrcamentoContexto orcContext = new OrcamentoContexto();
            orcContext.despesas.Add(despesa);
            formPrincipal.definirBruto();
            MessageBox.Show("Sucesso!", "Despesa adicionada com sucesso");
        }

        public void addComboDespesa()
        {
            foreach(Despesa despesa in formPrincipal.getSelecionada().getDespesa())
            {
                comboDespesas.Items.Add(despesa);
            }
        }

        public int getMes()
        {
            return formPrincipal.getSelecionada().mes;
        }

        private void janelaDespesas_Load(object sender, EventArgs e)
        {
            comboDespesas.Items.Clear();
            addComboDespesa();
        }

        private void novaDespesaBotao_Click(object sender, EventArgs e)
        {
            novaDespesa novaDespesa = new novaDespesa(this);
            novaDespesa.ShowDialog(this);
        }

        private void comboDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionada = (Despesa) comboDespesas.SelectedItem;

            valueDescricao.Text = selecionada.descricao;
            valueTipo.Text = selecionada.tipo;
            valueValor.Text = string.Format(ptBR, "{0:0,0.00}", selecionada.valor.ToString());
            valueData.Text = selecionada.data;
        }
    }
}
