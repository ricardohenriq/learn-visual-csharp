using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual char Status { get; set; }
        public virtual Endereco EnderecoResidencial { get; set; }

        public override string ToString()
        {
            return "Id:" + Id  + "\n" +
                "Nome:" + Nome + "\n" +
                "Login:" + Login + "\n" +
                "Senha:" + Senha + "\n" +
                "Status:" + Status + "\n" +
                EnderecoResidencial.ToString();
        }
    }
}