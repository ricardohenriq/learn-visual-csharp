using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Banco
    {
        public string Nome { get; set; }
        public List<Conta> Contas { get; set; }

        public Banco()
        {
            Contas = new List<Conta>();
        }
    }
}
