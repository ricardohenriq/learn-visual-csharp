using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        
        public Conta(string Titular, double Saldo)
        {
            this.Titular = Titular;
            this.Saldo = Saldo;
            this.Numero = new Random().Next(1, 99999999);
        }

        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
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

        public bool Transfere(double valor, Conta destino)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Titular, Numero);
        }
    }
}
