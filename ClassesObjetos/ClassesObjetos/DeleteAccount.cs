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
    public partial class DeleteAccount : Form
    {
        private Banco banco = new Banco();

        public DeleteAccount(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
            this.createCombobox();
        }

        public void createCombobox()
        {
            foreach (Conta conta in banco.Contas)
            {
                correntistaComboBox.Items.Add(conta.Titular);
            }
        }

        private void encerrarContaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = banco.Contas.Find(p => p.Titular == correntistaComboBox.SelectedItem.ToString());
                banco.Contas.Remove(conta);
                MessageBox.Show("Conta deletada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Lançada");
            }
        }
    }
}
