using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiposPrimitivosVariaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Bill Gates";
            MessageBox.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade = 35;
            MessageBox.Show(idade.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double peso = 78.650;
            float pesoFloat = 78.650f;
            MessageBox.Show(peso.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char caracter = 'Ç';
            MessageBox.Show(caracter.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = "Bill Gates";
            int idade = 35;
            MessageBox.Show("Meu nome é: " + name.ToString() +
                "\nMinha idade é: " + idade.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double PI = 3.14;
            int PIInteiro = (int) PI;
            MessageBox.Show(PIInteiro.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Comentário de uma linha
            /*
            Comentário de multiplas linhas
            */

            MessageBox.Show("//Comentário de uma linha\n\n\n/*\nComentário de multiplas linhas\n*/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
                Tipo    | Tamanho | Valores Possíveis
                -------------------------------------
                bool    | 1 byte  | true e false
                byte    | 1 byte  | 0 a 255
                sbyte   | 1 byte  | -128 a 127
                short   | 2 bytes | -32768 a 32767
                ushort  | 2 bytes | 0 a 65535
                int     | 4 bytes | -2147483648 a 2147483647
                uint    | 4 bytes | 0 a 4294967295
                long    | 8 bytes | -9223372036854775808L a 9223372036854775807L
                ulong   | 8 bytes | 0 a 18446744073709551615
                float   | 4 bytes | Números até 10 elevado a 38 ex: 10.0f e 12.5f
                double  | 8 bytes | Números até 10 elevado a 308 ex: 10.0 e 12.33
                decimal | 16 bytes| Números com até 28 casas decimais ex: 10.991m e 33.333m
                char    | 2 bytes | Caracteres únicos delimitado por aspas simples ex: 'a' e 'Ç'
            */

            MessageBox.Show(
                "Tipo    | Tamanho | Valores Possíveis\n"+
                "-------------------------------------\n" +
                "bool    | 1 byte  | true e false\n" +
                "byte    | 1 byte  | 0 a 255\n" +
                "sbyte   | 1 byte  | -128 a 127\n" +
                "short   | 2 bytes | -32768 a 32767\n" +
                "ushort  | 2 bytes | 0 a 65535\n" +
                "int     | 4 bytes | -2147483648 a 2147483647\n" +
                "uint    | 4 bytes | 0 a 4294967295\n" +
                "long    | 8 bytes | -9223372036854775808L a 9223372036854775807L\n" +
                "ulong   | 8 bytes | 0 a 18446744073709551615\n" +
                "float   | 4 bytes | Números até 10 elevado a 38 ex: 10.0f e 12.5f\n" +
                "double  | 8 bytes | Números até 10 elevado a 308 ex: 10.0 e 12.33\n" +
                "decimal | 16 bytes| Números com até 28 casas decimais ex: 10.991m e 33.333m\n" +
                "char    | 2 bytes | Caracteres únicos delimitado por aspas simples ex: 'a' e 'Ç'\n"
            );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
                Operadores Relacionais
                ------------------
                == Igual
	            === Igual até os Tipos
	            != ou <> Diferente
	            > Maior que
	            < Menor que
	            >= Maior ou Igual que
	            <= Menor ou Igual que

                Operadores Lógicos
                -------------------
                ! Nega o operando (inverte valor/tipo)
                && "E" Retorna TRUE se ambos forem verdadeiros
                || "OU" Retorna TRUE se algum for verdadeiro

                Operadores de Atribuição
                ------------------------
                = Atribuição simples
                *= Váriavel recebe a multiplicação dela mesma pela variavel que esta sendo atribuida
                /= Váriavel recebe a divisão dela mesma pela variavel que esta sendo atribuida
                -= Váriavel recebe a subtração dela mesma pela variavel que esta sendo atribuida
                += Váriavel recebe a soma dela mesma pela variavel que esta sendo atribuida

                Operadores Aritmeticos
                ----------------------
                + soma (3 + variavel)
                - subtração (3 - variavel)
                * multiplicação (3 * variavel)
                / divisão (3 / variavel)
                % resto da divisão(3 % variavel)
            */

            MessageBox.Show(
                "Operadores Relacionais\n" +
                "------------------\n" +
                "== Igual\n"+
                "=== Igual até os Tipos\n" +
                "!= ou <> Diferente\n" +
                "> Maior que\n" +
                "< Menor que\n" +
                ">= Maior ou Igual que\n" +
                "<= Menor ou Igual que\n" +

                "Operadores Lógicos\n" +
                "------------------\n" +
                "! Nega o operando(inverte valor / tipo)\n" +
                "&& \"E\" Retorna TRUE se ambos forem verdadeiros\n" +
                "|| \"OU\" Retorna TRUE se algum for verdadeiro\n" +

                "Operadores de Atribuição\n" +
                "------------------------\n" +
                "= Atribuição simples\n" +
                "*= Váriavel recebe a multiplicação dela mesma pela variavel que esta sendo atribuida\n" +
                "/= Váriavel recebe a divisão dela mesma pela variavel que esta sendo atribuida\n" +
                "-= Váriavel recebe a subtração dela mesma pela variavel que esta sendo atribuida\n" +
                "+= Váriavel recebe a soma dela mesma pela variavel que esta sendo atribuida\n" +

                "Operadores Aritmeticos\n" +
                "----------------------\n" +
                "+ soma(3 + variavel)\n" +
                "- subtração(3 - variavel)\n" +
                "* multiplicação(3 * variavel)\n" +
                "/ divisão(3 / variavel)\n" +
                "% resto da divisão(3 % variavel)"
            ) ;
        }
    }
}
