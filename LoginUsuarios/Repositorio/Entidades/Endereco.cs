using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Endereco
    {
        /* "{ get; set; }" se chama "Auto-Implemented Properties", isto cria os métodos acessores 
        get e set de forma generica (pode ter implementação completa e/ou com outro 
        modificador de acesso)*/
        public virtual int Id { get; set; }
        /* A palavra chave "virtual" marca os métodos e propriedades que podem ser extendidos por 
        uma sub-classe, ou seja, que permite ter o comportamento alterado através de um override. 
        Assim sendo, ao criar uma subclasse, é possível tornar ela mais específica, mas sem ter de 
        reimplementar toda a classe, pois é possível alterar o comportamento pontualmente.*/
        public virtual string Rua { get; set; }
        public virtual string Quadra { get; set; }
        public virtual string Lote { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string PontoReferencia { get; set; }

        public Endereco()
        {

        }
        
        public Endereco(int Id, string Rua, string Quadra, string Lote, string Bairro,
            string CEP, string Complemento, string PontoReferencia)
        {
            this.Id = Id;
            this.Rua = Rua;
            this.Quadra = Quadra;
            this.Lote = Lote;
            this.Bairro = Bairro;
            this.CEP = CEP;
            this.Complemento = Complemento;
            this.PontoReferencia = PontoReferencia;
        }

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
