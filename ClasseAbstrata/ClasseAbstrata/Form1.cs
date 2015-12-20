using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAbstrata
{
    public partial class ClasseAbstrata : Form
    {
        public ClasseAbstrata()
        {
            InitializeComponent();
        }

        private void createContaPoupancaButton_Click(object sender, EventArgs e)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            MessageBox.Show("ContaPoupanca contaPoupanca = new ContaPoupanca();");
        }

        private void createContaCorrenteButton_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            MessageBox.Show("ContaCorrente contaCorrente = new ContaCorrente();");
        }

        private void createContaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ContaPoupanca contaPoupanca = new ContaPoupanca();//Funciona\n" +
                "ContaCorrente contaCorrente = new ContaCorrente();//Funciona\n" +
                "Conta conta = new Conta();//Não Funciona");
        }

        private void atributoEstaticoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de Contas Corrente: " + ContaCorrente.getTotalContas().ToString() + "\n"
                + "Total de Contas Poupanca: " + ContaPoupanca.getTotalContas().ToString());
        }
    }
}
