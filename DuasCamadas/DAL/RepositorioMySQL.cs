using Modelos;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class RepositorioMySQL
    {
        private readonly string StringDeConexao = "server = localhost; user id = root; pwd = batata; database = duas-camadas";

        private void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection conexao = ObterConexao();
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                foreach(MySqlParameter parameter in parameters)
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
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdText: $"SELECT * FROM produtos WHERE nome like @Nome", conexao);
                    cmd.Parameters.AddWithValue(parameterName: "@Nome", nome);
                    dr = cmd.ExecuteReader();
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

            private MySqlConnection ObterConexao()
            {
                return new MySqlConnection(StringDeConexao);
            }
        }
    }
