using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Correntista
    {
        public string Nome { get; set; }
        //public string Nome {get;private set;} não será possivel usar o set fora da classe
        public string Cpf { get; set; }

        /*public Correntista(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }*/
    }
}