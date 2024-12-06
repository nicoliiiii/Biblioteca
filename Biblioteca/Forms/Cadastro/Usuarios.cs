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
using Biblioteca.Classes;

namespace Biblioteca.Forms.Cadastro
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioEntidade usuario = new UsuarioEntidade();
            usuario.LOGIN = txtLoginUsuario.Text;
            usuario.SENHA = txtSenhaUsuario.Text;
            DAOUsuarios dao = new DAOUsuarios();
            dao.Inserir(usuario);
            MessageBox.Show("Sucesso", "Cadastrado com sucesso");
            Close();
        }
    }
}
