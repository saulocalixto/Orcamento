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
    public partial class novaDespesa : Form
    {
        private janelaDespesas formPrincipal;
        String tipo;

        public novaDespesa(janelaDespesas formPrincipal)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.formPrincipal = formPrincipal;
        }

        public void addDespesa()
        {
            Despesa despesa = new Despesa();

            despesa.descricao = textDescricao.Text;
            despesa.valor = Convert.ToDouble(textValor.Text);
            despesa.data = dataDespesa.Text.ToString();
            despesa.tipo = this.tipo;
            despesa.mes = formPrincipal.getMes() + 1;

            formPrincipal.addDespesa(despesa);
        }

        public void addTipo()
        {
            comboTipo.Items.Add("Transporte");
            comboTipo.Items.Add("Lazer");
            comboTipo.Items.Add("Serviços");
            comboTipo.Items.Add("Doméstico");
            comboTipo.Items.Add("Estudos");
            comboTipo.Items.Add("Alimentos");
            comboTipo.Items.Add("Cartão de Crédito");
            comboTipo.Items.Add("Outros");
        }

        private void botaoAdd_Click(object sender, EventArgs e)
        {
            addDespesa();
            textDescricao.Text = "";
            textValor.Text = "";
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = comboTipo.SelectedItem.ToString();
        }

        private void novaDespesa_Load(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            int maximoDias = DateTime.DaysInMonth(ano, (formPrincipal.getMes() + 1));
            int mes = formPrincipal.getMes() + 1;
            addTipo();
            dataDespesa.Value = new DateTime(ano, mes, 1);
            dataDespesa.MinDate = new DateTime(ano, mes, 1);
            dataDespesa.MaxDate = new DateTime(ano, mes, maximoDias);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
