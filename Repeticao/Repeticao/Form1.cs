using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificarFatorialButton_Click(object sender, EventArgs e)
        {
            int resultado = 1;
            for (int i = 1; i < Int32.Parse(fatorialTextBox.Text)+1; i++)
            {
                resultado *= i;
            }
            MessageBox.Show(resultado.ToString());
        }

        private void verificarContadorButton_Click(object sender, EventArgs e)
        {
            int contador = Int32.Parse(contadorTextBox.Text);
            int resultado = 0;
            while (contador > 0)
            {
                resultado += contador;
                contador--;
            }
            MessageBox.Show(resultado.ToString());
        }
    }
}
