using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Endereco
    {
        public virtual int Id { get; set; }
        public virtual string Rua { get; set; }
        public virtual string Quadra { get; set; }
        public virtual string Lote { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string PontoReferencia { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + "\n" +
                "Rua: " + Rua + "\n" +
                "Quadra: " + Quadra + "\n" +
                "Lote: " + Lote + "\n" +
                "Bairro: " + Bairro + "\n" +
                "CEP: " + CEP + "\n" +
                "Complemento: " + Complemento + "\n" +
                "Ponto de Referencia: " + PontoReferencia;
        }
    }
}
