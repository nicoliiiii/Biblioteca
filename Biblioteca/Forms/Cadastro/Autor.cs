using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Cadastro
{
    public partial class Autor : Form
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;
        public Autor()
        {
            InitializeComponent();
        }

        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNomeAutor.Text = "";
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "insert into autores (NomeAutor) Values (@nomeautor)";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

           
            comando.Parameters.Add(new MySqlParameter("@nomeautor", txtNomeAutor.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Autor cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
