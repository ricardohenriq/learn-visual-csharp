using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Repositorio;
using Repositorio.Entidades;

namespace Repositorio.Test
{
    //Isto se chama Data Annotation isto serve para validação
    [TestFixture]
    public class UsuarioRepositorioTest
    {
        [Test]
        public void ValidarLoginTestExist()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = true;
            bool result = usuarioRepositorio.ValidarLogin("login1");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidarLoginTestNotExist()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = false;
            bool result = usuarioRepositorio.ValidarLogin("login9");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidarAcessoTestWrongPassword()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = false;
            bool result = usuarioRepositorio.ValidarAcesso("login2", "senha2");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidarAcessoTestWrongLogin()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = false;
            bool result = usuarioRepositorio.ValidarAcesso("login2", "senha1");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidarAcessoTestWrongLoginPassword()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = false;
            bool result = usuarioRepositorio.ValidarAcesso("login2", "senha4");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidarAcessoTestOKLoginPassword()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            bool expected = true;
            bool result = usuarioRepositorio.ValidarAcesso("login1", "senha1");
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ConsultarTest()
        {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            string expected = new Usuario(1, "Nome Sobrenome 1", "login1", "senha1", 
                'A', new Endereco(1, "Rua 1", "Quadra 1", "Lote 1", "Bairro 1", "11111111", "Complemento 1", "Ponto de Referencia 1")).ToString();
            string result = usuarioRepositorio.Consultar().ElementAt(0).ToString();

            /*
            Para comparar 2 Objetos é necessário sobrescrever (override) os métodos:
            Object.Equals e Object.GetHashCode 
            para algo assim:

            public override bool Equals(object obj) {
                Student other = obj as Student;
                if(other == null) {
                    return false;
                }
                return (this.Name == other.Name) && (this.ID == other.ID);
            }

            public override int GetHashCode() {
                return 33 * Name.GetHashCode() + ID.GetHashCode();
            }

            Ou sobrescrever o método Object.ToString e comparar as string retornadas 
            pelo método.
            */
            Assert.AreEqual(expected, result);
        }
    }
}
