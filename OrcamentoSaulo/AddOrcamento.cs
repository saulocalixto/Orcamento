using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoSaulo
{
    public partial class AddOrcamento : Form
    {

        int mesEscolha;
        private OrcamentoSaulo formPrincipal;
        public AddOrcamento(OrcamentoSaulo formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void addMes()
        {
            comboMes.Items.Add("Janeiro");
            comboMes.Items.Add("Fevereiro");
            comboMes.Items.Add("Março");
            comboMes.Items.Add("Abril");
            comboMes.Items.Add("Maio");
            comboMes.Items.Add("Junho");
            comboMes.Items.Add("Julho");
            comboMes.Items.Add("Agosto");
            comboMes.Items.Add("Setembro");
            comboMes.Items.Add("Outubro");
            comboMes.Items.Add("Novembro");
            comboMes.Items.Add("Dezembro");
        }

        public void addOrcamento()
        {
            Orcamento1 orcamento = new Orcamento1();

            string renda = boxRenda.Text;
            double bruto = Convert.ToDouble(renda);
            orcamento.mes = mesEscolha;
            orcamento.bruto = bruto;

            this.formPrincipal.addOrcamento(orcamento);
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            addOrcamento();
            boxRenda.Text = "";
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesEscolha = comboMes.SelectedIndex;
        }

        private void AddOrcamento_Load(object sender, EventArgs e)
        {
            addMes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
