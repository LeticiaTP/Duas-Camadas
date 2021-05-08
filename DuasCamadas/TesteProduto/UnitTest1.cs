using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;

namespace TesteProduto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void ConsultarProduto()
        {
            Produto pro = null;
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            {
                pro = rep.Consultar(nome: "rivotril");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(pro);
        }
    }


}
