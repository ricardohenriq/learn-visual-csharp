using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using FluentNHibernate.Mapping;

namespace Repositorio.Mapeamento
{
    public class EnderecoMap : ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Id(c => c.Id);
            Map(c => c.Rua);
            Map(c => c.Quadra);
            Map(c => c.Lote);
            Map(c => c.Bairro);
            Map(c => c.CEP);
            Map(c => c.PontoReferencia).Column("ponto_referencia");
            Table("enderecos");
        }
    }
}
