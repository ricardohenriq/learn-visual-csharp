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
            bool result = usuarioRepositorio.ValidarAcesso("login1", "senha2");
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
            //IList<Usuario> expected;
            IList<Usuario> result = usuarioRepositorio.Consultar();
            Assert.AreEqual(expected, result);
        }
    }
}
