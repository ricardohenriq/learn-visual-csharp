using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularStrings
{
    public partial class manipularStrings : Form
    {
        public manipularStrings()
        {
            InitializeComponent();
        }

        private void concatenacaoButton_Click(object sender, EventArgs e)
        {
            string materia = "Arquitetura";
            string titulo = materia + " e " + " Design de Software";
            titulo += " ! "; // concatena a ! no fim do texto

            MessageBox.Show(
                "string materia = \"Arquitetura\";" + "\n" +
                "string titulo = materia + \" e \" + \" Design de Software\";" + "\n" +
                "titulo += \" !\"; // concatena a ! no fim do texto" + "\n\n\n" +
                titulo
                );
        }

        private void interpolacaoButton_Click(object sender, EventArgs e)
        {
            string nome = "Bill Gates";
            int idade = 42;
            string texto = string.Format("Olá {0}, a sua idade é {1}", nome, idade);

            MessageBox.Show(
                "string nome = \"Bill Gates\";" + "\n" +
                "int idade = 42;" + "\n" +
                "string texto = string.Format(\"Olá {0}, a sua idade é {1}\", nome, idade);" + "\n\n\n" +
                texto
                );
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            string texto = "Bill Gates,42,são paulo,brasil";
            string[] colunas = texto.Split(',');

            MessageBox.Show(
                "string texto = \"Bill Gates, 42, são paulo, brasil\";" + "\n" +
                "string[] colunas = texto.Split(',');" + "\n\n\n" +
                colunas.Length
                );
        }

        private void toUpperButton_Click(object sender, EventArgs e)
        {
            /*
            Sempre que chamamos um método em um objeto String, um novo objeto 
            é criado e retornado pelo método, mas o original nunca é modificado. 
            Strings são imutáveis.
            */

            string curso = "fn13";
            string maiusculo = curso.ToUpper();

            MessageBox.Show(
                "string curso = \"fn13\";" + "\n" +
                "string maiusculo = curso.ToUpper();" + "\n\n\n" +
                maiusculo
                );
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            /*
            Podemos concatenar as invocações de método, já que uma string é devolvida a cada invocação
            */

            string curso = "fn13";
            curso = curso.ToUpper().Replace("1", "2");

            MessageBox.Show(
                "string curso = \"fn13\";" + "\n" +
                "curso = curso.ToUpper().Replace(\"1\", \"2\");" + "\n\n\n" +
                curso
                );
        }

        private void substringButton_Click(object sender, EventArgs e)
        {
            string nomeCompleto = "Bill Gates";
            string nome = nomeCompleto.Substring(0, 4);

            MessageBox.Show(
                "string nomeCompleto = \"Bill Gates\";" + "\n" +
                "string nome = nomeCompleto.Substring(0, 4);" + "\n\n\n" +
                nome
                );
        }

        private void indexOfButton_Click(object sender, EventArgs e)
        {
            string nomeCompleto = "William Henry Gates III";
            int posicaoDoEspaco = nomeCompleto.IndexOf(" "); // Só pega a primeira aparição
            MessageBox.Show(
                "string nomeCompleto = \"William Henry Gates III\";" + "\n" +
                "int posicaoDoEspaco = nomeCompleto.IndexOf(\" \");" + "\n\n\n" +
                posicaoDoEspaco.ToString()
                );
        }
    }
}
