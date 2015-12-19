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
    public partial class Home : Form
    {
        private Banco banco = new Banco();

        public Home()
        {
            InitializeComponent();
        }

        private void criarContaButton_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount(banco);
            createAccountForm.Show();
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccountForm = new DeleteAccount(banco);
            deleteAccountForm.Show();
        }

        private void depositarButton_Click(object sender, EventArgs e)
        {
            Depositar depositarForm = new Depositar(banco);
            depositarForm.Show();
        }

        private void sacarButton_Click(object sender, EventArgs e)
        {
            Sacar sacarForm = new Sacar(banco);
            sacarForm.Show();
        }
    }
}