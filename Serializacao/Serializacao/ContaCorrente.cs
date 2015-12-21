using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacao
{
    public class ContaCorrente : Conta
    {
        private static string officialName = "Conta Corrente - CAIXA";
        private static int totalDeContas = 0;

        public ContaCorrente(Titular titular, double value)
        {
            this.Titular = titular;
            this.Saldo = value;
            ContaCorrente.totalDeContas++;
        }

        private ContaCorrente()
        {
            //Existe para prevenir a seguinte exception
            //Unhandled Exception: System.InvalidOperationException: CLASSE cannot 
            //be serialized because it does not have a parameterless constructor.
        }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }

        public static int getTotalContas()
        {
            return ContaCorrente.totalDeContas;
        }
    }
}
