using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;
using NHibernate;
using NHibernate.Linq;

namespace Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        public bool ValidarLogin(string login)
        {
            /* O bloco using provê ao desenvolvedor a habilidade de se criar um bloco de 
            código isolado dentro de um determinado programa. Podemos com ele, atingir 
            dois objetivos:
            - Criar um alias para um determinado namespace ou tipo;
            - Criar um escopo que ao final de sua execução, libera recursos automaticamente 
            através do método Dispose().
            É importante lembrar que para a utilização do bloco using, necessita-se que a 
            classe usada no escopo, implemente a interface IDisposable, ou seja, a classe 
            deve implementar o método Dispose
            
            using (MemoryStream data1 = new MemoryStream())
            using (MemoryStream data2 = new MemoryStream())
            {
                //se comporta como se data2 estive-se aninhado em data1
            }
            é o mesmo que:
            using (MemoryStream data1 = new MemoryStream(), 
                    data2 = new MemoryStream())
            {

            }
            
            */
            using (ISession session = SessionFactory.AbrirSession()) 
            {
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) select e).Count() > 0;
            }
        }

        public bool ValidarAcesso(string login, string senha)
        {
            using (ISession session = SessionFactory.AbrirSession()) 
            {
                /*
                from <nome_do_objeto_base_da_colecao> in <colecao> where <condicoes_podem_ser_baseardas_em_propriedades_do_objeto_da_colecao> 
                && <condicoes_podem_ser_baseardas_em_qualquer_coisa> select <o_que_devera_ser_retornado_pela_consulta_inclusive_o_porprio_objeto>
                */
                return (from e in session.Query<Usuario>() where e.Login.Equals(login) && e.Senha.Equals(senha) select e).Count() > 0;
            }
        }

        /* "IList" é a interface que todas as listas não genéricas implementam, isto "<Usuario>" 
        é um Generics especificando o tipo de cada elemento da lista, logo este método poderá retornar 
        qualquer lista que implemente a interface IList cujos elementos sejam do tipo Usuario*/
        public IList<Usuario> Consultar()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from c in session.Query<Usuario>().Fetch(c => c.EnderecoResidencial) select c).ToList();
            }
        }
    }
}