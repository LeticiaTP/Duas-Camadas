using System;

namespace Modelos
{
    public class Produto
    {
        private int id;
        private string nome;
        private string marca;
        private string tipo;
        private int quantidade;

        public Produto() { }

        public Produto(string nome, string marca, string tipo, int quantidade)
        {
            Nome = nome;
            Marca = marca;
            Tipo = tipo;
            Quantidade = quantidade;
        }

        public Produto(int id, string nome, string marca, string tipo, int quantidade) :this(nome, marca, tipo, quantidade)
        {
            Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value.ToUpper(); }
        public string Marca { get => marca; set => marca = value.ToUpper(); }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
