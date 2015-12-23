using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Fornecedor
    {
        public virtual int Id { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string Descricao { get; set; }
    }
}
