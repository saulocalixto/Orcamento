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
    public partial class acrescentarReceita : Form
    {
        private OrcamentoSaulo formPrincipal;
        public acrescentarReceita(OrcamentoSaulo formPrincipal)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.formPrincipal = formPrincipal;
        }

        private void botaoAcrescentar_Click(object sender, EventArgs e)
        {
            double receita = Convert.ToDouble(textBoxValor.Text);
            formPrincipal.getSelecionada().addReceita(receita);
            formPrincipal.definirBruto();
        }

        private void acrescentarReceita_Load(object sender, EventArgs e)
        {
        }

        private void FormFilho_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
