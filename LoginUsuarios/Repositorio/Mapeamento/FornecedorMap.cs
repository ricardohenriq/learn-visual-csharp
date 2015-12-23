using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using FluentNHibernate.Mapping;

namespace Repositorio.Mapeamento
{
    public class FornecedorMap : ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Id(c => c.Id);
            Map(c => c.CNPJ);
            Map(c => c.NomeFantasia);
            Map(c => c.RazaoSocial);
            Map(c => c.Descricao);
            Table("fornecedores");
        }
    }
}
