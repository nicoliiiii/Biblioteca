using System;
using System.Windows.Forms;

namespace Biblioteca.Forms.Cadastro
{
    public partial class USUARIO : Form
    {
        private USUARIO usuario;

        public USUARIO()
        {
            InitializeComponent();
           
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            
           // usuario = new USUARIO();
           // usuario.Usuario = txtLogin.Text;
           // usuario.Senha = txtSenha.Text;

          //  if (usuario.Logar())
            {
                Principal p = new Principal();
                p.FormClosed += FecharForm; 
                this.Hide();
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                p.Show();
            }
          //  else
            {
                MessageBox.Show("Login ou senha inválidos.");
            }
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
