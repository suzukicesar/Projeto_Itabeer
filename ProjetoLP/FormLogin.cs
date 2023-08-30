using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text.ToLower();
            senha = txtSenha.Text;
            if (usuario.Equals("adm") && senha.Equals("123"))
            {
                FormCadastro formcad = new FormCadastro();
                formcad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário / Senha errada!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
