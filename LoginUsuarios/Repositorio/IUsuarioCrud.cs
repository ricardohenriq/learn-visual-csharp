using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    /* Isto "<T>" é um Generics, quer dizer que a interface irá trabalhar ou conter um 
    objeto de uma classe qualquer especificada pela letra "T"*/
    //Interface que atuará como a nossa fachada de acesso aos dados.
    interface IUsuarioCrud<T>
    {
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        /*Retornará um objeto da classe qualquer "T"*/
        T RetornarPorId(int Id);
        /*Retornará um objeto que implementa a interface "IList" que trabalha / contem 
        objetos da classe "T"*/
        IList<T> Consultar();
    }
}
