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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Professor professor = new Professor(txtNome.Text, mskCPF.Text, txtEmail.Text, mskTelefone.Text);
            professor.Inserir();
            MessageBox.Show("Professor Gravado com sucesso!");
            LimparControles();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // se o text do botão for igual a "..."
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
                    Professor Professor = new Professor();
                    Professor.ConsultarPorId(Convert.ToInt32(txtId.Text));
                    txtEmail.Text = Professor.Email;
                    mskCPF.Text = Professor.Cpf;
                    mskTelefone.Text = Professor.Telefone;
                    txtNome.Text = Professor.Nome;

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Professor Professor = new Professor();
            if (Professor.Alterar(new Professor(Convert.ToInt32(txtId.Text), txtNome.Text, mskTelefone.Text)))
                MessageBox.Show("Dados do Professor alterados com sucesso!");
            else
                MessageBox.Show("Falha ao alterar dados do Professor!");
            // var comm = Banco.Abrir();
            // comm.CommandText = "update tb_Professor set nome_Professor = '"+txtNome.Text+"'," +
            // " sexo_Professor = '"+sexo+ "', telefone_Professor = '"+mskTelefone.Text +
            // "' where id_Professor = "+txtId.Text;
            // comm.ExecuteNonQuery();
            // comm.Connection.Close();

            LimparControles();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show(
                "Deseja realmente excluir o Professor?",
                "Excluir Professor...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (msg == DialogResult.Yes && txtId.Text != string.Empty)
            {
                var comm = Banco.Abrir();
                comm.CommandText = "delete from tb_professor where id_professor = " + txtId.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Professor excluído com sucesso!");
                LimparControles();
            }

        }
        private void LimparControles()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
