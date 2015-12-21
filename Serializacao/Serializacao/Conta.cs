using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacao
{
    public abstract class Conta
    {
        public double Saldo { get; set; }
        public Titular Titular { get; set; }

        public Conta()
        {

        }

        public virtual void Saca(double valor)
        {
            //não faz nada
        }

        public bool Deposita(double valor)
        {
            if(valor > 0)
            {
                this.Saldo += valor;
                return true;
            }
            return false;
        }
    }
}
