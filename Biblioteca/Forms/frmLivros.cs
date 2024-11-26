using Biblioteca.Cadastro;
using Biblioteca.DAO;
using Biblioteca.Entidades;
using Biblioteca.Forms.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class frmLivros : Form
    {
        DataTable dados;
        DAOLivros dao = new DAOLivros();
        int LinhaSelecionada;
        public frmLivros()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(LivrosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridLivros.DataSource = dao.ObterLivro();
        }

        private void dtGridLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string TituloLivro = Convert.ToString(dtGridLivros.Rows[e.RowIndex].Cells[0].Value);
                EditarLivro editar = new EditarLivro(TituloLivro);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridLivros.DataSource = dao.ObterLivro();
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            Livros l = new Livros();
            l.FormClosed += Fechou_Editar_FormClosed;
            l.ShowDialog();
        }
    }
}
