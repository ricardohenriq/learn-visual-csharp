using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    /*Classes POCO são classes sem implementação alguma. Elas apenas servem para a 
    estrtuturação de dados.*/
    public class Fornecedor
    {
        /* "{ get; set; }" se chama "Auto-Implemented Properties", isto cria os métodos acessores 
        get e set de forma generica (pode ter implementação completa e/ou com outro 
        modificador de acesso)*/
        public virtual int Id { get; set; }
        /* A palavra chave "virtual" marca os métodos e propriedades que podem ser extendidos por 
        uma sub-classe, ou seja, que permite ter o comportamento alterado através de um override. 
        Assim sendo, ao criar uma subclasse, é possível tornar ela mais específica, mas sem ter de 
        reimplementar toda a classe, pois é possível alterar o comportamento pontualmente.*/
        public virtual string CNPJ { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string Descricao { get; set; }
    }
}
