using Modelos;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class RepositorioMySQL : IRepositorio
    {
        private readonly string StringDeConexao = "server = localhost; user id = root; pwd = batata; database = duas-camadas";

        private void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection conexao = ObterConexao();
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                foreach (MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
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
        public void Inserir(Produto produto)
        {
            try
            {
                ExecuteNonQuery($"INSERT INTO produtos (nome, marca, tipo, quantidade) values (@Nome,@Marca,@Tipo,@Quantidade)", new MySqlParameter(parameterName: "@Nome", produto.Nome), new MySqlParameter(parameterName: "@Marca", produto.Marca), new MySqlParameter(parameterName: "@Tipo", produto.Tipo), new MySqlParameter(parameterName: "@Quantidade", produto.Quantidade));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Deletar(string nome)
        {
            try
            {
                ExecuteNonQuery($"DELETE FROM produtos WHERE nome = @Nome", new MySqlParameter(parameterName: "@Nome", nome));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Produto Consultar(string nome)
        {
            Produto pro = null;
            MySqlConnection conexao = ObterConexao();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(conexao, sql:"SELECT * FROM produtos WHERE nome like @Nome", parameters: new MySqlParameter(parameterName:"@Nome", nome));
                while (dr.Read())
                {
                    pro = new Produto();

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

        private static MySqlDataReader ExecuteReader(MySqlConnection conexao, string sql, params MySqlParameter[] parameters)
        {
            MySqlDataReader dr;
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            return dr;
        }

        private MySqlConnection ObterConexao()
        {
            return new MySqlConnection(StringDeConexao);
        }
    }
}