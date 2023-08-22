using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CRUDUserStore.Model;

namespace CRUDUserStore.Tests.UserTestUnit
{
    [TestClass]
    public class UserTestUnit
    {
  
        // Instanciar usuário: valida se o usuário estar instanciado
        [TestMethod]
        public void InstaciarUser()
        {
            User user = new User(); // Pq usar User ao invés de var?
            Assert.IsNotNull(user);
        }

        public void CreatUserIdPasswordEmail()
        {
            var user = new User(); // pq nesse caso não foi necessário indicar o tipo da var?
            var guid = Guid.NewGuid();
            user.Id = guid; // Pq usar esse método? tem como gerar um Id consecutivo?
            user.Name = "Gallileu";
            user.Password = "123456";
            user.Email = "gallileu@gmail.com";
            user.Valid = true;

            // Testes
            Assert.IsFalse(user.Id != guid);
            Assert.AreEqual(user.Id, guid);
            Assert.IsTrue(user.Valid);
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.Password);

        }


    }
}
