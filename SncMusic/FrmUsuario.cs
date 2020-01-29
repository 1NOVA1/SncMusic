using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SncMusic
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, txtSituacao.Text);
            usuario.Inserir();
            MessageBox.Show("Usuario Gravado com sucesso!");
            LimparControles();

        }
        private void LimparControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtSituacao.Clear();
            txtNome.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                //alterar o texto do botão para "Buscar"
                btnBuscar.Text = "Buscar";
                //tornar o txtid Enable true
                txtId.Enabled = true;
                //tornar o txtid readonly false
                txtId.ReadOnly = false;
                //colocar o foco (cursor) no txtid e limpe
                txtId.Focus();
                txtId.Clear();
            }
            //senão
            else
            {
                //se txtid for diferente de vazio então consulte o aluno
                if (txtId.Text != string.Empty)
                {
                    Usuario usuario = new Usuario();
                    usuario.ConsultarPorId(Convert.ToInt32(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtSenha.Text = usuario.Senha;
                    txtSituacao.Text = usuario.Situacao;

                    //altere o texto do botão para "..."
                    btnBuscar.Text = "...";
                    //tornar o txtId Enable false
                    txtId.Enabled = false;
                    //tornar o txtId ReadOnly true
                    txtId.ReadOnly = true;
                }

            }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
        }


        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.Alterar(new Usuario(Convert.ToInt32(txtId.Text), txtNome.Text, txtSenha.Text, txtSituacao.Text, txtEmail.Text)))
                MessageBox.Show("Dados do usuário alterados com sucesso!");
            else
                MessageBox.Show("Falha ao alterar dados do usuário!");
                LimparControles();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show(
               "Deseja realmente excluir o Usuário?",
               "Excluir Usuário...",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && txtId.Text != string.Empty)
            {
                var comm = Banco.Abrir();
                comm.CommandText = "delete from tb_usuario where id_usuario = " + txtId.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!");
                LimparControles();
            }
          
        }
    }
}

