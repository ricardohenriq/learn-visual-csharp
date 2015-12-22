using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace LoginUsuarios
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ErrorProvider loginFormError = new ErrorProvider();
            loginFormError.Clear();

            if (loginTextBox.Text == string.Empty)
            {
                loginFormError.SetError(loginTextBox, "Informe o login do usuário");
                return;
            }
            if (passwordTextBox.Text == string.Empty)
            {
                loginFormError.SetError(passwordTextBox, "Informe a senha do usuário");
                return;
            }
            try
            {
                usuarioRepo = new UsuarioRepositorio();
                if ((usuarioRepo.ValidarAcesso(loginTextBox.Text, passwordTextBox.Text)))
                {
                    MessageBox.Show("Login efetuado com sucesso");
                }
                else
                {
                    MessageBox.Show("Login e/ou Senha inválidos", "Login Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o sistema" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
