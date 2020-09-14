using NUnit.Framework;
using Penske.Mobilep.Data;
using System.Linq;

namespace Penske.Mobilep.TestData
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //var usuario = new Users
            //{
            //    FullName = "Test",
            //    Email = "TEST@GMAIL.COM",
            //    Password = "123",
            //    Perfil = 1
            //};

            //using (var context = new PenskeMobileContext())
            //{
            //    context.AddRange(usuario);
            //    context.SaveChanges();
            //}

            using (var context = new PenskeMobileContext())
            {
                var usuariosTop = context.Users.Take(5).ToList();

                var pagina = 1;
                var muestra = 10;

                var usuarios = context.Users.Skip(5).Take(5).ToList();
            }



            Assert.Pass();
        }
    }
}