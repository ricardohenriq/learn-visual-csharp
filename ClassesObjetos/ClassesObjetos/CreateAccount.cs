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
    public partial class CreateAccount : Form
    {
        private Banco banco = new Banco();

        public CreateAccount(Banco banco)
        {
            this.banco = banco;
            InitializeComponent();
        }

        private void criarConta_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta(titularTextBox.Text, Double.Parse(depositoTextBox.Text));
                banco.Contas.Add(conta);
                MessageBox.Show("Conta criada com sucesso");
            }catch(Exception ex)
            {
                MessageBox.Show("Exception Lançada");
            }
        }
    }
}
