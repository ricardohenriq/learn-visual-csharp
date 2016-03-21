using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    /*É possível dividir a definição de uma class ou uma struct, interface ou
    metódo em dois ou mais arquivos fonte.Cada arquivo contém uma seção para 
    definição de tipo ou método, e todas as partes são combinadas quando a 
    aplicação é compilada.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }
    }
}
