using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorio
    {
        void Inserir(Produto produto);
        void Deletar(string nome);
        public Produto Consultar(string nome);
        public List<Produto> Listar();
    }
}
