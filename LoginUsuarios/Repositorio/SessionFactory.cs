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
    public class SessionFactory
    {
        private static string server = "localhost";
        private static string database = "agenda";
        private static string uid = "agendaadmin";
        private static string password = "agendaadmin";
        private static string ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        private static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }
            IPersistenceConfigurer configDB = MySQLConfiguration.Standard.ConnectionString(ConnectionString);
            var configMap = Fluently.Configure().Database(configDB)
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.UsuarioMap>())
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.EnderecoMap>())
                .Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapeamento.FornecedorMap>());
            session = configMap.BuildSessionFactory();
            return session;
        }
        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
