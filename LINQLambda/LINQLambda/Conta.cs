using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLambda
{
    public class Conta
    {
        public double Saldo;
        public string Titular;

        public Conta(string Titular, double Saldo)
        {
            this.Saldo = Saldo;
            this.Titular = Titular;
        }

        public bool sacar(double value)
        {
            if(this.Saldo >= value)
            {
                this.Saldo -= value;
                return true;
            }
            return false;
        }

        public bool depositar(double value)
        {
            if (value > 0)
            {
                this.Saldo += value;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Titular + " - " + this.Saldo + "\n";
        }
    }
}
