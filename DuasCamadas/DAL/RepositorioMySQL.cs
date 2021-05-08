using Modelos;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class RepositorioMySQL
    {
        private readonly string StringDeConexao = "server = localhost; user id = root; pwd = batata; database = duas-camadas";

        public void Inserir(Produto produto)
        {
            MySqlConnection conexao = ObterConexao();
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

        public void Deletar(string nome)
        {
            MySqlConnection conexao = ObterConexao();
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"DELETE FROM produtos WHERE nome = @Nome", conexao);
                cmd.Parameters.AddWithValue(parameterName: "@Nome", nome);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

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
