using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesObjetos
{
    public partial class Depositar : Form
    {
        private Banco banco = new Banco();

        public Depositar(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
            this.createCombobox();
        }

        public void createCombobox()
        {
            foreach (Conta conta in banco.Contas)
            {
                correntistasComboBox.Items.Add(conta.Titular);
            }
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = banco.Contas.Find(p => p.Titular == correntistasComboBox.SelectedItem.ToString());
                if (Double.Parse(valorTextBox.Text) > 0)
                {
                    conta.Saldo += Double.Parse(valorTextBox.Text);
                    MessageBox.Show("Deposito realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o deposito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Lançada");
            }
        }
    }
}
