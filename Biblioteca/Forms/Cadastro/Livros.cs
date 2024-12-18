﻿using Biblioteca.DAO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Cadastro
{
    public partial class Livros : Form
    {
        private string LinhaConexao = "Server=localhost;Database=bibliotecaescola;Uid=root;Pwd=;";
        private MySqlConnection Conexao;

        
        public Livros()
        {
            InitializeComponent();
            DAOAutor dao_autor = new DAOAutor();
             cbxAutor.DataSource = dao_autor.PreencherComboBox();
            cbxAutor.DisplayMember = "NomeAutor";
            cbxAutor.ValueMember = "AutorId";

        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtTituloLivro.Text = "";
            cbxAutor.Text = "";
            txtGenero.Text = "";
            txtClassificacao.Text = "";
            txtNumPag.Text = "";
            txtAnoPubli.Text = "";
            chkDisponivel.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "insert into Livros (TituloLivro, AutorId, Genero,Classificacao,NumPag,AnoPubli,Disponivel) Values (@titulolivro, @autorid, @genero, @classificacao, @numpag,@anopubli, @disponivel)";

            Conexao = new MySqlConnection(LinhaConexao);
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            comando.Parameters.Add(new MySqlParameter("@titulolivro", txtTituloLivro.Text));
            comando.Parameters.Add(new MySqlParameter("@autorid", cbxAutor.SelectedValue));
            comando.Parameters.Add(new MySqlParameter("@genero", txtGenero.Text));
            comando.Parameters.Add(new MySqlParameter("@classificacao", txtClassificacao.Text));
            comando.Parameters.Add(new MySqlParameter("@numpag", txtNumPag.Text));
            comando.Parameters.Add(new MySqlParameter("@anopubli", txtAnoPubli.Text));
            comando.Parameters.Add(new MySqlParameter("@disponivel", chkDisponivel.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Livro cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Livros_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
