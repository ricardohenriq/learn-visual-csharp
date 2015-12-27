using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQLambda
{
    public partial class LINQLambda : Form
    {
        List<Conta> bank = new List<Conta>();

        public LINQLambda()
        {
            InitializeComponent();
            loadBank();
            //this.loadBank();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /*O Compilador pode inferir o tipo de cada variavel em uma Lambda, logo ele inferirá 
            que o o tipo de "c" é "Conta", a esquerda do "=>" esta o que será passado à lambda, 
            a direita as operações que a lambda irá realizar*/
            Conta conta = bank.Find(c => c.Titular == correntistaTextBox.Text);
            MessageBox.Show(conta.ToString());
        }

        public void loadBank()
        {
            bank.Add(new Conta("Correntista 1", 1423));
            bank.Add(new Conta("Correntista 2", 452));
            bank.Add(new Conta("Correntista 3", 1234));
            bank.Add(new Conta("Correntista 4", 54637));
            bank.Add(new Conta("Correntista 5", 152335));
            bank.Add(new Conta("Correntista 6", 54));
            bank.Add(new Conta("Correntista 7", 1341));
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var filtradas = bank.Where(c => { return c.Saldo > 500; });
            /*
                Quando declaramos uma função anônima que tem apenas uma linha que devolve um valor, 
                podemos remover inclusive as chaves e o return da declaração do lambda:
                var filtradas = bank.Where(c => c.Saldo > 2000);
            */
            string result = "";
            foreach (Conta conta in filtradas)
            {
                result += conta;
            }

            MessageBox.Show(result);
        }

        private void saldoTotalButton_Click(object sender, EventArgs e)
        {
            double saldoTotal = bank.Sum(c => c.Saldo);
            MessageBox.Show(saldoTotal.ToString());
        }

        private void saldoMediaButton_Click(object sender, EventArgs e)
        {
            double saldoMedia = bank.Average(c => c.Saldo);
            MessageBox.Show(saldoMedia.ToString());

            /*
            Quando utilizamos esses métodos de agregação em uma lista com tipos primitivos, 
            o lambda é um argumento opcional.Por exemplo, se tivéssemos uma lista de double, 
            poderíamos utilizar o seguinte código para calcular a média dos números:

            List<double> saldos = new List<double>();
            double media = saldos.Average();
            */
        }

        private void saldoContarButton_Click(object sender, EventArgs e)
        {
            int saldoCount = bank.Count(c => c.Saldo > 500);
            MessageBox.Show(saldoCount.ToString());
        }

        private void saldoMinButton_Click(object sender, EventArgs e)
        {
            double saldoMin = bank.Min(c => c.Saldo);
            MessageBox.Show(saldoMin.ToString());
        }

        private void saldoMaxButton_Click(object sender, EventArgs e)
        {
            double saldoMax = bank.Max(c => c.Saldo);
            MessageBox.Show(saldoMax.ToString());
        }

        private void trabalhaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O LINQ, além de trabalhar com listas, também pode ser utilizados com outros tipos de coleções, podemos utilizar o LINQ com qualquer objeto que implemente a interface IEnumerable, ou seja, ele pode ser utilizado com qualquer objeto que possa ser passado para a instrução foreach. Isso inclui todos os tipos de coleções (Listas, conjuntos e dicionários) e arrays.");
        }

        private void LINQSQLButton_Click(object sender, EventArgs e)
        {
            var filtradas = from c in bank
                            where c.Saldo < 2000
                            select c;
            /*
            Poderia devolver somente um atributo do objeto: select c.Saldo;
            Poderia devolver o objeto todo: select c;
            Poderia devolver determinados campos: select new { c.Saldo, c.Titular };
            para isso teria de instanciar um objeto com os campos desejados.
            LINQ supor ordenação (até com criterio de desempate).
            Nesse código, o compilador do C# cria um novo tipo que será utilizado para 
            guardar o resultado da busca. Esse tipo não possui um nome dentro do código 
            e por isso o objeto devolvido é chamado de Objeto Anônimo. Quando utilizamos 
            o objeto anônimo no LINQ, somos forçados a utilizar a inferência de tipos (palavra var).
            */

            string result = "";
            foreach (Conta conta in filtradas)
            {
                result += conta;
            }

            MessageBox.Show(result);
        }
    }
}
