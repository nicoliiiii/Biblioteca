using Biblioteca.DAO;
using Biblioteca.Entidades;
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

        }
    }
}
