using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeControle
{
    public partial class estruturaControle : Form
    {
        public estruturaControle()
        {
            InitializeComponent();
        }

        private void verificar_Click(object sender, EventArgs e)
        {
            int idade;
            Int32.TryParse(idadeTextBox.Text, out idade);

            if (idade >= 18 && idade <= 65)
            {
                MessageBox.Show("Pode tirar carteira sr. " + nomeTextBox.Text);
            }
            else if(idade < 18 && idade >= 1 || idade < 100 && idade >= 1)
            {
                MessageBox.Show("Não pode tirar carteira sr. " + nomeTextBox.Text);
            }
            else
            {
                MessageBox.Show("Numero Inválido");
            }
        }

        private void verificarSwitch_Click(object sender, EventArgs e)
        {
            switch(Int32.Parse(numeroTextBox.Text))
            {
                case 10:
                    MessageBox.Show("Acertou o número");
                    break;
                case 11:
                    MessageBox.Show("Passou perto");
                    break;
                case 9:
                    MessageBox.Show("Passou perto");
                    break;
                default:
                    MessageBox.Show("Errou");
                    break;
            }                   
        }
    }
}