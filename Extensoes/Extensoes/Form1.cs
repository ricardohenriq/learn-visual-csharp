using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringExtensions;

namespace Extensoes
{
    public partial class Extensoes : Form
    {
        public Extensoes()
        {
            InitializeComponent();
        }

        private void stringExtensionsButton_Click(object sender, EventArgs e)
        {
            /*
            É importante lembrar que o método só pode ser acessado caso ainda não 
            exista um outro método com o mesmo nome e tipos de parâmetros na classe. 
            Isto é, não seria possível estender a classe string com um novo método 
            ToString() pois ele já existe. Só podemos adicionar novos comportamentos.
            */

            string texto = "banco";
            string plural = texto.Pluralize();

            MessageBox.Show(
                "string texto = \"banco\";" + "\n" +
                "string plural = texto.Pluralize();" + "\n\n\n" +
                plural
                );
        }
    }
}
