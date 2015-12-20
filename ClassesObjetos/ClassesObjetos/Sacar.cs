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
    public partial class Sacar : Form
    {
        private Banco banco = new Banco();

        public Sacar(Banco banco)
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

        private void sacarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = banco.Contas.Find(p => p.Titular == correntistasComboBox.SelectedItem.ToString());
                //var o C# irá inferir o tipo
                //var conta = banco.Contas.Find(p => p.Titular == correntistasComboBox.SelectedItem.ToString());

                if (conta.Saldo >= Double.Parse(valorTextBox.Text))
                {
                    conta.Saldo -= Double.Parse(valorTextBox.Text);
                    
                    Label message = new Label();
                    message.Text = "Saque realizado com sucesso";
                    message.AutoSize = false;
                    message.TextAlign = ContentAlignment.BottomCenter;
                    message.Dock = DockStyle.Fill;
                    message.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");

                    //Demonstração do initializer
                    /*
                        Label message = new Label(){
                            Text = "Saque realizado com sucesso";
                            AutoSize = false;
                            TextAlign = ContentAlignment.BottomCenter;
                            Dock = DockStyle.Fill;
                            ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");
                        };
                    */

                    this.Controls.Add(message);

                    DialogResult dialog = MessageBox.Show("Saque realizado com sucesso");

                    if (dialog == DialogResult.Abort || dialog == DialogResult.OK)
                    {
                        //Application.Exit();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o saque");
                }
            }
            catch (Exception ex)
            {
                //throw new CustomException("Exception Lançada");
                //throw new CustomException();
                MessageBox.Show("Exception Lançada");
            }
        }
    }
}
