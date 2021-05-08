using Modelos;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class RepositorioMySQL
    {
        public void Inserir(Produto produto)
        {
            MySqlConnection conexao = new MySqlConnection(connectionString: "server = localhost; user id = root; pwd = batata; database = duas-camadas");
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"INSERT INTO produtos (nome, marca, tipo, quantidade) values (@Nome,@Marca,@Tipo,@Quantidade)", conexao);
                cmd.Parameters.AddWithValue(parameterName: "@Nome", produto.Nome);
                cmd.Parameters.AddWithValue(parameterName: "@Marca", produto.Marca);
                cmd.Parameters.AddWithValue(parameterName: "@Tipo", produto.Tipo);
                cmd.Parameters.AddWithValue(parameterName: "@Quantidade", produto.Quantidade);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Deletar(string v)
        {
            throw new NotImplementedException();
        }

        public Produto Consultar(string marca)
        {
            Produto pro = null;
            MySqlConnection conexao = new MySqlConnection(connectionString: "server = localhost; user id = root; pwd = batata; database = duas-camadas");
            MySqlDataReader dr = null;
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"SELECT * FROM Produtos WHERE marca='vitarella'", conexao);
                cmd.Parameters.AddWithValue(parameterName: "@Marca", marca);
                dr = cmd.ExecuteReader();

                pro = new Produto();
                while (dr.Read())
                {
                    pro.Id = dr.GetInt32(column: "Id");
                    pro.Nome = dr.GetString(column: "Nome");
                    pro.Marca = dr.GetString(column: "Marca");
                    pro.Tipo = dr.GetString(column: "Tipo");
                    pro.Quantidade = dr.GetInt32(column: "Quantidade");
                    break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
             {
                conexao.Close();
                if (dr != null)
                {
                    dr.Close();
                }
                    
            }
            return pro;
        }
    }
}
