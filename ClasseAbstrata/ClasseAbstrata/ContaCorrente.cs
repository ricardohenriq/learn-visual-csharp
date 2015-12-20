using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class ContaCorrente : Conta
    {
        private static string officialName = "Conta Corrente - CAIXA";

        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
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
