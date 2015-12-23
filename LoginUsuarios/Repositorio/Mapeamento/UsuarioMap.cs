using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using FluentNHibernate.Mapping;

namespace Repositorio.Mapeamento
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            LazyLoad();
            Id(c => c.Id);
            Map(c => c.Nome);
            Map(c => c.Login);
            Map(c => c.Senha);
            Map(c => c.Status);
            //HasOne(c => c.EnderecoResidencial).Not.LazyLoad();
            HasOne(c => c.EnderecoResidencial);
            Table("usuarios");
        }
    }
}
