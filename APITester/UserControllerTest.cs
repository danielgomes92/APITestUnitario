using APITestUnitario.Controllers;
using APITestUnitario.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APITester
{
    [TestClass]
    public class UserControllerTest
    {
        UserController controller;
        User user;

        [TestInitialize]
        
        public void Start()
        {
            controller = new UserController(); //pode ser usado a ID
            user = new User();
        }

        //Retorno do Teste OK
        [TestMethod]
        [DataRow("Junior")]
        [DataRow("Mariano")]
        [DataRow("Daniel")]
        public void Post_Test(string nome)
        {
            user.Nome = nome;
            var responseAPI = controller.Post(user); // recebe o usuário
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }

        //Retorno do Teste BadRequest
        //[TestMethod]
        //public void Post_Test_BadRequest()
        //{
        //    user.Nome = "Junior";
        //    var responseAPI = controller.Post(user); // recebe o usuário
        //    Assert.IsInstanceOfType(responseAPI, typeof(BadRequestResult));
        //}
    }
}