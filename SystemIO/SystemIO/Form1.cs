using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIO
{
    public partial class SystemIO : Form
    {
        public SystemIO()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            /*
            A entrada de dados no C# funciona em duas etapas. Na primeira etapa, temos uma 
            classe abstrata que representa uma sequência de bytes na qual podemos realizar 
            operações de leitura e escrita. Essa classe abstrata é chamada de Stream.

            Como o Stream é uma classe abstrata, não podemos usá-la diretamente, precisamos 
            de uma implementação para essa classe. No caso de leitura ou escrita em arquivos, 
            utilizamos um tipo de Stream chamado FileStream, que pode ser obtido através do 
            método estático Open da classe File. Quando utilizamos o Open, devemos passar o 
            nome do arquivo que será aberto e devemos informá-lo o que queremos fazer com o 
            arquivo (ler ou escrever).
            */
            if (File.Exists(fileUrlTextBox.Text))
            {
                Stream entrada = File.Open(fileUrlTextBox.Text, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);

                string texto = "";
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    texto += linha + "\n";
                    linha = leitor.ReadLine();
                }
                leitor.Close(); //FECHAR O ARQUIVO É MANDATÓRIO
                entrada.Close(); //FECHAR O ARQUIVO É MANDATÓRIO

                MessageBox.Show(texto);

                /*
                Ao invés de chamar o método ReadLine para cada linha, podemos utilizar 
                o método ReadToEnd da classe StreamReader. Esse método devolve uma string 
                com todo o conteúdo do arquivo.
                */
            }
        }

        private void salvarTextoButton_Click(object sender, EventArgs e)
        {
            StreamWriter escritor = null;
            try
            {
                string path = "C:\\Users\\Henrique\\Documents\\Visual Studio 2015\\Projects\\SystemIO\\SystemIO\\SAIDA.txt";
                /*Usar o arroba @ indica que a string deve ser interpretada como um literal
                string path = @"C:\Users\Henrique\Documents\Visual Studio 2015\Projects\SystemIO\SystemIO\SAIDA.txt";
                */
                //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAIDA.txt");
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                escritor = new StreamWriter(path, true);
                escritor.WriteLine(mesageTextBox.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }

            /*
            O using automaticamente fecha os arquivos utilizados dentro do bloco 
            mesmo quando uma exceção é lançada pelo código.
            */

            /*StreamWriter escritor = null;
            string path = "C:\\Users\\Henrique\\Documents\\Visual Studio 2015\\Projects\\SystemIO\\SystemIO\\SAIDA.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (escritor = new StreamWriter(path, true))
            {
                escritor.WriteLine(mesageTextBox.Text);
            }*/
        }
    }
}
