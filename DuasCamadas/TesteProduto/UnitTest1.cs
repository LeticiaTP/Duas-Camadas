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
        public void InserirProduto()
        {
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            { 
                rep.Inserir(produto: new Produto(nome: "bicoito", marca: "futurinhos", tipo: "biscoitos e bolachas", quantidade:29));
                
            }
            catch (Exception ex)
            {
            
            }
            Assert.IsNotNull(rep.Consultar(nome: "biscoito"));
        }

        public void DeletarProduto()
        {
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            {
                rep.Deletar(nome:"biscoito");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNull(rep.Consultar(nome: "biscoito"));
        }

        public void ConsultarProduto()
        {
            Produto pro = null;
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            {
                pro = rep.Consultar(nome: "biscoito");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(pro);
        }
    }


}
