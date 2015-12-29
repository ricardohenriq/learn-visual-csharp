using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Repositorio
{
    /*Será responsável por disponibilizar uma session que representa o nosso contexto.
    Nesta classe iremos definir a string de conexão e a conexão com o banco de dados MySql.
    A classe SessionFactory possui métodos estáticos para criar e abrir uma sessão que 
    representa o contexto e a conexão com o banco de dados */
    public class SessionFactory
    {
        private static string server = "localhost";
        private static string database = "agenda";
        private static string uid = "agendaadmin";
        private static string password = "agendaadmin";
        private static string ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        //Interface do NHibernate, de uma fabrica de session.
        private static ISessionFactory session;

        //Cria/Retorna uma fabrica de sessão configurada com o Fluent
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }

            //Interface do Fluent NHibernate.
            IPersistenceConfigurer configDB = MySQLConfiguration.Standard.ConnectionString(ConnectionString);

            //Fluently é uma classe do Fluent NHibernate.
            var configMap = Fluently.Configure().Database(configDB)
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.UsuarioMap>())
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.EnderecoMap>())
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.FornecedorMap>());

            //Se cria uma fabrica de sessão com as configurações realizadas a cima.
            session = configMap.BuildSessionFactory();
            return session;
        }

        //Encapsula a abertura de sessão
        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
