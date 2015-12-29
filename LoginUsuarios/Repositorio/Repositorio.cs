using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Repositorio.Entidades;

namespace Repositorio
{
    /*Classe repositorio com um Generics "T" implementando uma interface que também utiliza 
    um Generics de determinada classe "T", "where T : class" isto é uma constrait do que "T"
    deve ser: class, struct, new(), <base class name>, <interface name>, U*/
    public class Repositorio<T> : IUsuarioCrud<T> where T : class
    {
        public void Inserir(T entidade)
        {
            //Cria uma sessão (poderia usar o mesmo using)
            using (ISession session = SessionFactory.AbrirSession())
            {
                //Cria uma transação (poderia usar o mesmo using)
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        //Persiste o objeto no banco
                        session.Save(entidade);
                        //Comita a transação
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //Verifica se o objeto foi corretamente iserido no banco e a transação 
                        //foi corretamente comitada
                        if (!transacao.WasCommitted)
                        {
                            //Faz rollback caso o obejto não tenha sido inserido no banco
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir Cliente : " + ex.Message);
                    }
                }
            }
        }

        public void Alterar(T entidade)
        {
            //Cria uma sessão (poderia usar o mesmo using)
            using (ISession session = SessionFactory.AbrirSession())
            {
                //Cria uma transação (poderia usar o mesmo using)
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        //Atualiza o objeto no banco
                        session.Update(entidade);
                        //Comita a transação
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //Verifica se o objeto foi corretamente iserido no banco e a transação 
                        //foi corretamente comitada
                        if (!transacao.WasCommitted)
                        {
                            //Faz rollback caso o obejto não tenha sido inserido no banco
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Alterar Cliente : " + ex.Message);
                    }
                }
            }
        }

        public void Excluir(T entidade)
        {
            //Cria uma sessão (poderia usar o mesmo using)
            using (ISession session = SessionFactory.AbrirSession())
            {
                //Cria uma transação (poderia usar o mesmo using)
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        //Deleta o objeto no banco
                        session.Delete(entidade);
                        //Comita a transação
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //Verifica se o objeto foi corretamente iserido no banco e a transação 
                        //foi corretamente comitada
                        if (!transacao.WasCommitted)
                        {
                            //Faz rollback caso o obejto não tenha sido inserido no banco
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Excluir Cliente : " + ex.Message);
                    }
                }
            }
        }

        public T RetornarPorId(int Id)
        {
            //Cria uma sessão
            using (ISession session = SessionFactory.AbrirSession())
            {
                //Recupera um objeto com base no Id
                return session.Get<T>(Id);
            }
        }

        public IList<T> Consultar()
        {
            //Cria uma sessão
            using (ISession session = SessionFactory.AbrirSession())
            {
                //Realiza um select no banco
                return (from c in session.Query<T>() select c).ToList();
            }
        }
    }
}
