using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio; //Tem de adicionar uma referencia a este projeto 
//Solution Explorer -> Add -> Reference -> Project
using Repositorio.Entidades;

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
                UsuarioRepositorio usuarioRepo = new UsuarioRepositorio();
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

        private void singUpButton_Click(object sender, EventArgs e)
        {
            ErrorProvider singUpFormError = new ErrorProvider();
            singUpFormError.Clear();
            if (nameTextBox.Text == string.Empty)
            {
                singUpFormError.SetError(nameTextBox, "Informe o nome do usuário");
                return;
            }
            if (loginSingUptextBox.Text == string.Empty)
            {
                singUpFormError.SetError(loginSingUptextBox, "Informe o login do usuário");
                return;
            }
            if (passwordSingUpTextBox.Text == string.Empty)
            {
                singUpFormError.SetError(passwordSingUpTextBox, "Informe a senha do usuário");
                return;
            }
            UsuarioRepositorio usuarioRepo = new UsuarioRepositorio();
            if ((usuarioRepo.ValidarLogin(loginSingUptextBox.Text)))
            {
                MessageBox.Show("Login já esta Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Usuario user = new Usuario();
                    user.Login = loginSingUptextBox.Text;
                    user.Nome = nameTextBox.Text;
                    user.Senha = passwordSingUpTextBox.Text;
                    user.Status = 'A';
                    usuarioRepo.Inserir(user);
                    MessageBox.Show("Login Cadastrado com sucesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioRepositorio repositorio = new UsuarioRepositorio();
                var listUsuario = repositorio.Consultar();
                MessageBox.Show(listUsuario.ElementAt(0).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar todos os usuários " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}