using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoLP
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtNum.Text = "";
            txtUf.Text = "";
            txtTelefone.Text = "";
            txtSetor.Text = "";
            txtFuncao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=WIN10;Initial Catalog=TrabalhoLPBDMANHA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tbFuncionario(nome, cpf, email, endereco, num, cidade, uf, telefone, setor, funcao) VALUES ('" + txtNome.Text + "','" + txtCpf.Text + "','" + txtEmail.Text + "','" + txtEndereco.Text + "','" + txtNum.Text + "','" + txtCidade.Text + "','" + txtUf.Text + "','" + txtTelefone.Text + "','" + txtSetor.Text + "','" + txtFuncao.Text + "')", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                btnConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=WIN10;Initial Catalog=TrabalhoLPBDMANHA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("UPDATE tbFuncionario SET nome='" + txtNome.Text + "', cpf='" + txtCpf.Text + "', email='" + txtEmail.Text + "', endereco='" + txtEndereco.Text + "', num='" + txtNum.Text + "', cidade='" + txtCidade.Text + "', uf='" + txtUf.Text + "', telefone='" + txtTelefone.Text + "', setor='" + txtSetor.Text + "', funcao='" + txtFuncao.Text + "' WHERE cod='" + txtCodigo.Text + "'", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                btnConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=WIN10;Initial Catalog=TrabalhoLPBDMANHA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbFuncionario WHERE nome like'" + txtConsulta.Text + "%' ORDER BY nome ASC", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnConsultarFilt_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=WIN10;Initial Catalog=TrabalhoLPBDMANHA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT cod, nome, setor, funcao FROM tbFuncionario WHERE nome like'" + txtConsulta.Text + "%' ORDER BY nome ASC", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=WIN10;Initial Catalog=TrabalhoLPBDMANHA;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("DELETE FROM tbFuncionario WHERE cod='" + txtCodigo.Text + "'", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                btnConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
