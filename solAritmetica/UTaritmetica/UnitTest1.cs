using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTaritmetica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            const int numa = 1;
            const int numb = 2;
            const int resp = 3;
            //act
            using (srvAritmetica.WSaritmeticaClient cliente = new srvAritmetica.WSaritmeticaClient())
            {
                var rsp = cliente.sumar(numa, numb);

                //assert
                Assert.AreEqual(resp, rsp.respuesta);
            }
            //assert
        }

     }
}
