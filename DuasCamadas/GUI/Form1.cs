using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DAL;
using Modelos;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarProdutos();

        }

        private void ListarProdutos()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                gridProdutos.DataSource = null;
                gridProdutos.DataSource = rep.Listar();
                gridProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IRepositorio rep = new RepositorioMySQL();          
            try
            {
                rep.Inserir(produto: new Produto(txtNome.Text, txtMarca.Text, txtTipo.Text, int.Parse(txtQtd.Text)));
                ListarProdutos();
                MessageBox.Show(text: $"Produto {txtNome.Text} cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Erro ao tentar cadastrar produto: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
